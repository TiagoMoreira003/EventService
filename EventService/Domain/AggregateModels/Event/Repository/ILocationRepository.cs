// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITeamAcronymRepository.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ITeamAcronymRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Repository
{
	using EventService.Domain.AggregateModels;
	using EventService.Domain.SeedWork;
	/// <summary>
	/// <see cref="IEventLocationRepository"/>
	/// </summary>
	/// <seealso cref="IRepository{Location}"/>
	public interface IEventLocationRepository : IRepository<Location>
	{
	}
}