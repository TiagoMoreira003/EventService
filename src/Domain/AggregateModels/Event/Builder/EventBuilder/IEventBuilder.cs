// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEventBuilder.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// IEventBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Builder.EventBuilder
{
    using EventService.Domain.AggregateModels.Event;
    using System;

    /// <summary>
    /// <see cref="IEventBuilder"/>
    /// </summary>
    /// {seealso cref="IRepository{Event}" }
    public interface IEventBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Event Build();

        /// <summary>
        /// Creates new team.
        /// </summary>
        /// <param name="artist">The acronym.</param>
        /// <param name="date">The date.</param>
        /// <param name="musictype">The name.</param>
        /// <param name="location">The acronym.</param>
        /// <param name="description">The description.</param>
        /// <returns></returns>
        IEventBuilder NewEvent(string artist, DateTime date, MusicType musictype, Location location, string description);
    }
}