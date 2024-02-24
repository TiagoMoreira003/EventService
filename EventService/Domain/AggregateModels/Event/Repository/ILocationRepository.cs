// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILocationRepository.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ILocationRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Repository
{
	using EventService.Domain.AggregateModels;
	using EventService.Domain.SeedWork;

	/// <summary>
	/// <see cref="ILocationRepository"/>
	/// </summary>
	/// <seealso cref="IRepository{Location}"/>
	public interface ILocationRepository : IRepository<Location>
	{
	}
}