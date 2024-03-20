// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILocationRepository.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ILocationRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using EventService.Domain.SeedWork;

namespace EventService.Domain.AggregateModels.Event.Repository
{
	/// <summary>
	/// <see cref="ILocationRepository"/>
	/// </summary>
	/// <seealso cref="IRepository{Location}"/>
	public interface ILocationRepository : IRepository<Location>
	{
	}
}