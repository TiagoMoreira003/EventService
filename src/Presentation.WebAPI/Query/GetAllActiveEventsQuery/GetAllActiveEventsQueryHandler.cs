// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllActiveEventsQueryHandler.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// GetAllActiveEventsQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Presentation.WebAPI.Query.GetAllActiveEventsQuery
{
    using EventService.Domain.AggregateModels.Event;
    using EventService.Domain.AggregateModels.Event.Repository;
    using EventService.Domain.Exceptions;
    using MediatR;

    /// <summary>
    /// <see cref="GetAllActiveEventsQueryHandler" />
    /// </summary>
    /// <seealso cref="IRequestHandler{GetAllActiveEventsCommand}" />
    public class GetAllActiveEventsQueryHandler : IRequestHandler<GetAllActiveEventsQuery, List<Event>>
    {
        /// <summary>
        /// The event repository
        /// </summary>
        private readonly IEventRepository _eventRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllActiveEventsQueryHandler" /> class.
        /// </summary>
        /// <param name="eventRepository">The event repository.</param>
        public GetAllActiveEventsQueryHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        /// <summary>
        /// Handles the specified command.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        /// <exception cref="NotFoundException">The team with id {command.EventId} wasn't found.</exception>
        public async Task<List<Event>> Handle(GetAllActiveEventsQuery request, CancellationToken cancellationToken)
        {
            var events = await _eventRepository.GetAllActiveEventsAsync(cancellationToken);


            if (events is null || !events.Any())
            {
                throw new NotFoundException($"No exist no one event");
            }

            return events;
        }
    }
}