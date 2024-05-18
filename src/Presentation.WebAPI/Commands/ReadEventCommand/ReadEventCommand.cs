// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReadEventCommand.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ReadEventCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Commands.ReadEventCommand
{
    using MediatR;

    /// <summary>
    ///   <see cref="ReadEventCommand" />
    /// </summary>
    /// <seealso cref="INotification" />
    public class ReadEventCommand : INotification
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