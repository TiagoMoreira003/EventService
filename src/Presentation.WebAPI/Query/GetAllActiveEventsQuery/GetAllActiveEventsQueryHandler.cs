﻿// --------------------------------------------------------------------------------------------------------------------
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
	public class GetAllActiveEventsQueryHandler : IRequestHandler<GetAllActiveEventsQuery, IEnumerable<Event>>
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
		/// Handles a request
		/// </summary>
		/// <param name="request">The request</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>
		/// Response from the request
		/// </returns>
		/// <exception cref="NotFoundException">No events found.</exception>
		public async Task<IEnumerable<Event>> Handle(GetAllActiveEventsQuery request, CancellationToken cancellationToken)
		{
			var events = await _eventRepository.GetAllActiveEventsAsync(cancellationToken);

			if (events == null || !events.Any())
			{
				throw new NotFoundException("No events found.");
			}

			return events;
		}
	}
}