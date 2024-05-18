// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReadEventCommand.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ReadEventCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Presentation.WebAPI.Commands.ReadEventCommand
{
    using EventService.Domain.AggregateModels.Event;
    using EventService.Domain.AggregateModels.Event.Repository;
    using EventService.Domain.Exceptions;
    using MediatR;
    using System.Diagnostics.Tracing;

    /// <summary>
    /// <see cref="ReadEventCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{ReadEventCommand}" />
    public class ReadEventCommandHandler : INotificationHandler<ReadEventCommand>
    {
        /// <summary>
        /// The event repository
        /// </summary>
        private readonly IEventRepository _eventRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadEventCommandHandler"/> class.
        /// </summary>
        /// <param name="eventRepository">The event repository.</param>
        public ReadEventCommandHandler(IEventRepository eventRepository)
        {
            this._eventRepository = eventRepository;
        }

        public async Task<Event> Handle(ReadEventCommand request, CancellationToken cancellationToken)
        {
            Event existingEvent = await this._eventRepository.GetByIdAsync(request.EventId, cancellationToken);

            if (existingEvent is null)
            {
                throw new EntityNotFoundException($"The entity with ID {request.EventId} does not exist.");
            }

            return existingEvent;
        }
    }
}