// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitOfWork.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// IUnitOfWork
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.SeedWork
{
	using System;
	using System.Threading;
	using System.Threading.Tasks;

	/// <summary>
	/// <see cref="IUnitOfWork"/>
	/// </summary>
	/// <seealso cref="IDisposable"/>
	public interface IUnitOfWork : IDisposable
	{
		/// <summary>
		/// Saves the entities asynchronous.
		/// </summary>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default);
	}
}
