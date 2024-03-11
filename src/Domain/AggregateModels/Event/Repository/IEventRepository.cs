// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEventRepository.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// IEventRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Repository
{
	using EventService.Domain.SeedWork;
	using System;
	using System.Threading;
	using System.Threading.Tasks;

	/// <summary>
	///   <see cref="IEventRepository" />
	/// </summary>
	/// <seealso cref="IRepository{Team}" />
	public interface IEventRepository : IRepository<Event>
	{
		Task<Event> GetAsync(Guid guid, CancellationToken token);
	}
}