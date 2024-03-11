// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventRepository.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Infrastructure.Repository
{
	using EventService.Domain.AggregateModels.Event;
	using EventService.Domain.AggregateModels.Event.Repository;

	/// <summary>
	/// <see cref="EventRepository"/>
	/// </summary>
	/// <seealso cref="IEventRepository" />
	/// <seealso cref="GenericRepository{Event}"/>
	internal class EventRepository : GenericRepository<Event>, IEventRepository
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EventRepository"/> class.
		/// </summary>
		/// <param name="context">The context.</param>
		public EventRepository(EventServiceDBContext context)
			: base(context)
		{
		}
	}
}