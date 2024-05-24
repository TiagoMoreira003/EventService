// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteEventCommand.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// DeleteEventCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Commands.DeleteEventCommand
{
	using MediatR;

	/// <summary>
	///   <see cref="DeleteEventCommand" />
	/// </summary>
	/// <seealso cref="INotification" />
	public class DeleteEventCommand : INotification
	{
		/// <summary>
		/// Gets the event identifier.
		/// </summary>
		/// <value>
		/// The event identifier.
		/// </value>
		public Guid EventId { get; init; }
	}
}