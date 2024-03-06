// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDomainEvent.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// IDomainEvent
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.SeedWork
{
	using MediatR;

	/// <summary>
	/// <see cref="IDomainEvent"/>
	/// </summary>
	/// <seealso cref="INotification"/>
	public interface IDomainEvent : INotification
	{
	}
}