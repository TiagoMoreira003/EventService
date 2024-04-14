// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEventRepository.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// IEventRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using EventService.Domain.AggregateModels.Event.Repository.Models;
using EventService.Domain.SeedWork;
using System.Threading;
using System.Threading.Tasks;

namespace EventService.Domain.AggregateModels.Event.Repository
{
	/// <summary>
	///   <see cref="IEventRepository" />
	/// </summary>
	/// <seealso cref="IRepository{Event}" />
	public interface IEventRepository : IRepository<Event>
	{
		Task<Event> GetByIdentifiersAsync(GetByIdentifiersModel model, CancellationToken cancellationToken);
	}
}