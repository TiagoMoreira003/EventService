// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByEventIdDto.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// GetByEventIdDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Dto.Input
{
    /// <summary>
    ///   <see cref="GetByEventIdDto" />
    /// </summary>
    public class GetByEventIdDto
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