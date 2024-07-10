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
	using System.Collections.Generic;

	/// <summary>
	/// <see cref="IEventBuilder" />
	/// </summary>

	public interface IEventBuilder
	{
		/// <summary>
		/// Adds the artist.
		/// </summary>
		/// <param name="artists">The artists.</param>
		/// <returns></returns>
		IEventBuilder AddArtist(List<string> artists);

		/// <summary>
		/// Builds this instance.
		/// </summary>
		/// <returns></returns>
		Event Build();

		/// <summary>
		/// Creates new event.
		/// </summary>
		/// <param name="eventDate">The event date.</param>
		/// <param name="musicType">Type of the music.</param>
		/// <param name="location">The location.</param>
		/// <param name="description">The description.</param>
		/// <param name="tenantId">The tenant identifier.</param>
		/// <param name="name">The name.</param>
		/// <param name="imageId">The image identifier.</param>
		/// <returns></returns>
		IEventBuilder NewEvent(EventDate eventDate, MusicType musicType, Location location, string description, Guid tenantId, string name, Guid imageId);

		/// <summary>
		/// Creates new eventidentifier.
		/// </summary>
		/// <param name="eventDate">The event date.</param>
		/// <param name="location">The location.</param>
		/// <param name="tenantId">The tenant identifier.</param>
		/// <returns></returns>
		IEventBuilder NewEventIdentifier(EventDate eventDate, Location location, Guid tenantId);
	}
}