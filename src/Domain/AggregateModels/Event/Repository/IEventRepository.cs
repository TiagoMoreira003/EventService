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

  using EventService.Domain.AggregateModels.Event.Repository.Models;
  using EventService.Domain.SeedWork;
  using System;
  using System.Collections.Generic;
  using System.Threading;
  using System.Threading.Tasks;
	/// <summary>
	///   <see cref="IEventRepository" />
	/// </summary>
	/// <seealso cref="IRepository{Event}" />
	public interface IEventRepository : IRepository<Event>
	{
    Task<IEnumerable<Event>> GetAllActiveEventsAsync(CancellationToken cancellationToken);    

		Task<Event> GetByIdAsync(Guid eventId, CancellationToken cancellationToken);

		Task<Event> GetByIdentifiersAsync(GetByIdentifiersModel model, CancellationToken cancellationToken);

		Task<Location> GetLocationAsync(Guid id, CancellationToken cancellationToken);
	}
}