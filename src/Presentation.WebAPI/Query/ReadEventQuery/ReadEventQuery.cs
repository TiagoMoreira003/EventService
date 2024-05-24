// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReadEventQuery.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ReadEventQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Query.ReadEventCommand
{
    using EventService.Domain.AggregateModels.Event;
    using MediatR;

    /// <summary>
    /// <see cref="ReadEventQuery" />
    /// </summary>
    /// <seealso cref="IRequest" />
    public class ReadEventQuery : IRequest<Event>
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