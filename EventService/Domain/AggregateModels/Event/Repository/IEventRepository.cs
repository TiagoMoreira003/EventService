// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITeamRepository.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ITeamRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Repository
{
	using EventService.Domain.SeedWork;
	using System.Threading;
	using System.Threading.Tasks;
	/// <summary>
	/// <see cref="ITeamRepository"/>
	/// </summary>
	/// <seealso cref="IRepository{Team}"/>
	public interface IEventRepository : IRepository<Event>
	{

	}
}