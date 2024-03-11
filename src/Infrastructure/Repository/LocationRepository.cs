// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationRepository.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// LocationRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Infrastructure.Repository
{
	using EventService.Domain.AggregateModels;
	using EventService.Domain.AggregateModels.Event.Repository;

	/// <summary>
	/// <see cref="LocationRepository"/>
	/// </summary>
	/// <seealso cref="GenericRepository{Location}"/>
	/// <seealso cref="ILocationRepository"/>
	internal class LocationRepository : GenericRepository<Location>, ILocationRepository
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationRepository"/> class.
		/// </summary>
		/// <param name="context">The context.</param>
		public LocationRepository(EventServiceDBContext context)
			: base(context)
		{
		}
	}
}