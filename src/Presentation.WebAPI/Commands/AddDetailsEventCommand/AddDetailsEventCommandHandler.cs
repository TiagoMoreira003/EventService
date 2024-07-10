// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddDetailsEventCommandHandler.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// AddDetailsEventCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Commands.AddDetailsEventCommand
{
	using EventService.Domain.AggregateModels.Event;
	using EventService.Domain.AggregateModels.Event.Repository;
	using EventService.Domain.AggregateModels.Event.Repository.Models;
	using EventService.Domain.Exceptions;
	using EventService.Presentation.WebAPI.Commands.UpdateImage;
	using MediatR;

	/// <summary>
	/// <see cref="AddDetailsEventCommandHandler"/>
	/// </summary>
	/// <seealso cref="IRequestHandler{AddDetailsEventCommand,Event}" />
	public class AddDetailsEventCommandHandler : IRequestHandler<AddDetailsEventCommand, Event>
	{
		/// <summary>
		/// The event repository
		/// </summary>
		private readonly IEventRepository eventRepository;

		/// <summary>
		/// The update image
		/// </summary>
		private readonly IImage updateImage;

		/// <summary>
		/// Initializes a new instance of the <see cref="AddDetailsEventCommandHandler"/> class.
		/// </summary>
		/// <param name="eventRepository">The event repository.</param>
		public AddDetailsEventCommandHandler(IEventRepository eventRepository, IImage updateImage)
		{
			this.eventRepository = eventRepository;
			this.updateImage = updateImage;
		}

		/// <summary>
		/// Handles a request
		/// </summary>
		/// <param name="request">The request</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>
		/// Response from the request
		/// </returns>
		public async Task<Event> Handle(AddDetailsEventCommand request, CancellationToken cancellationToken)
		{
			Event existingEvent = await this.eventRepository.GetAsync(request.EventId, cancellationToken);

			if (existingEvent is null)
			{
				throw new NotFoundException($"The event with {request.EventId} does not exist");
			}

			Location existingLocation = await this.eventRepository.GetLocationAsync(request.EventId, cancellationToken);

			if (existingLocation is null)
			{
				throw new NotFoundException($"The location with {request.EventId} does not exist");
			}

			if (request.Image is not null)
			{
				var imageId = Guid.NewGuid();

				await this.updateImage.UpdateImageAsync(request.Image, imageId, request.Image.ContentType);

				existingEvent.AddDetails(
				request.MusicType,
				request.Description,
				request.Name,
				imageId
				);
			}
			else
			{
				var imageId = Guid.Empty;

				existingEvent.AddDetails(
				request.MusicType,
				request.Description,
				request.Name,
				imageId
				);
			}

			if (request.Artists is not null)
			{
				foreach (string artist in request.Artists)
				{
					existingEvent.AddArtist(artist);
				}
			}

			existingLocation.AddAddress(new AddressModel
			{
				Street = request.Address.Street,
				State = request.Address.State,
				PostalCode = request.Address.PostalCode
			});

			await this.eventRepository.Update(existingEvent, cancellationToken);

			await this.eventRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

			return existingEvent;
		}
	}
}