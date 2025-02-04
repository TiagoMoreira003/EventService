// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateEventCommandHandler.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// UpdateEventCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Commands.UpdateEventCommand
{
    using EventService.Domain.AggregateModels.Event;
    using EventService.Domain.AggregateModels.Event.Repository;
    using EventService.Domain.AggregateModels.Event.Repository.Models;
    using EventService.Domain.Exceptions;
    using EventService.Presentation.WebAPI.Commands.UpdateImage;
    using MediatR;

    /// <summary>
    /// <see cref="UpdateEventCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{UpdateEventCommand,Event}" />
    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand, Event>
    {
        /// <summary>
        /// The event repository
        /// </summary>
        private readonly IEventRepository eventRepository;

        /// <summary>
        /// The update image
        /// </summary>
        private readonly IImage imageCommands;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEventCommandHandler"/> class.
        /// </summary>
        /// <param name="eventRepository">The event repository.</param>
        /// <param name="imageCommands">The update image.</param>
        public UpdateEventCommandHandler(IEventRepository eventRepository, IImage imageCommands)
        {
            this.eventRepository = eventRepository;
            this.imageCommands = imageCommands;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>
        /// Response from the request
        /// </returns>
        /// <exception cref="DuplicatedException">The event with that owner, location and date is duplicated</exception>
        public async Task<Event> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            Event existingEvent = await this.eventRepository.GetAsync(request.EventId, cancellationToken);

            if (existingEvent is null)
            {
                throw new NotFoundException($"The event with id {request.EventId} doesn't exist!");
            }

            Location existingLocation = await this.eventRepository.GetLocationAsync(request.EventId, cancellationToken);

            if (existingLocation is null)
            {
                throw new NotFoundException($"There is not a location associated with the event with id {request.EventId}");
            }

            if (request.Image != null)
            {
                await this.imageCommands.DeleteImageAsync(existingEvent.ImageId);

                var imageId = Guid.NewGuid();

                await this.imageCommands.UpdateImageAsync(request.Image, imageId, request.Image.ContentType);

                existingEvent.Update(new AllPropertiesModel
                {
                    Name = request.Name,
                    Description = request.Description,
                    EventDate = new EventDateModel
                    {
                        StartDate = request.EventDate.StartDate,
                        EndDate = request.EventDate.EndDate
                    },
                    MusicType = request.MusicType,
                    Artists = request.Artists,
                    ImageId = imageId,
                });
            }
            else
            {
                await this.imageCommands.DeleteImageAsync(existingEvent.ImageId);

                var imageId = Guid.Empty;

                existingEvent.Update(new AllPropertiesModel
                {
                    Name = request.Name,
                    Description = request.Description,
                    EventDate = new EventDateModel
                    {
                        StartDate = request.EventDate.StartDate,
                        EndDate = request.EventDate.EndDate
                    },
                    MusicType = request.MusicType,
                    Artists = request.Artists,
                    ImageId = imageId,
                });
            }

            existingLocation.Update(new LocationModel
            {
                Address = new AddressModel
                {
                    Street = request.Location.Address.Street,
                    State = request.Location.Address.State,
                    PostalCode = request.Location.Address.PostalCode
                },
                Latitude = request.Location.Latitude,
                Longitude = request.Location.Longitude
            });

            await this.eventRepository.Update(existingEvent, cancellationToken);

            await this.eventRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return existingEvent;
        }
    }
}