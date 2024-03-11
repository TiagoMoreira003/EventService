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

	/// <summary>
	///   <see cref="IEventRepository" />
	/// </summary>
	/// <seealso cref="IRepository{Event}" />
	public interface IEventRepository : IRepository<Event>
	{
	}
}