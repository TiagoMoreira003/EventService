// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReadEventQueryHandler.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ReadEventQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Presentation.WebAPI.Query.ReadEventHandler
{
    using EventService.Domain.AggregateModels.Event;
    using EventService.Domain.AggregateModels.Event.Repository;
    using EventService.Domain.Exceptions;
    using EventService.Presentation.WebAPI.Query.ReadEventCommand;
    using MediatR;

    /// <summary>
    /// <see cref="ReadEventQueryHandler" />
    /// </summary>
    /// <seealso cref="IRequestHandler{ReadEventQuery}" />
    public class ReadEventQueryHandler : IRequestHandler<ReadEventQuery, Event>
    {
        /// <summary>
        /// The event repository
        /// </summary>
        private readonly IEventRepository _eventRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadEventQueryHandler" /> class.
        /// </summary>
        /// <param name="eventRepository">The event repository.</param>
        public ReadEventQueryHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>
        /// Response from the request
        /// </returns>
        /// <exception cref="NotFoundException">The entity with ID {request.EventId} does not exist.</exception>
        public async Task<Event> Handle(ReadEventQuery request, CancellationToken cancellationToken)
        {
            Event existingEvent = await _eventRepository.GetByIdAsync(request.EventId, cancellationToken);

            if (existingEvent is null)
            {
                throw new NotFoundException($"The entity with ID {request.EventId} does not exist.");
            }

            return existingEvent;
        }
    }
}