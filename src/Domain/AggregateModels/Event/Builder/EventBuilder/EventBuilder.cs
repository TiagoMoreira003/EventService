// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventBuilder.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Builder.EventBuilder
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	///		<see cref="EventBuilder" />
	/// </summary>
	/// <seealso cref="IEventBuilder" />

	internal class EventBuilder : IEventBuilder
	{
		/// <summary>
		/// The event
		/// </summary>
		private Event Event;

		/// <summary>
		/// Adds the artist.
		/// </summary>
		/// <param name="artists">The artists.</param>
		/// <returns></returns>
		public IEventBuilder AddArtist(List<string> artists)
		{
			foreach (var artist in artists)
			{
				this.Event.AddArtist(artist);
			}
			return this;
		}

		/// <summary>
		/// Builds this instance.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException">The event object is not initialized.</exception>
		public Event Build()
		{
			if (Event is null)
			{
				throw new InvalidOperationException("The event object is not initialized.");
			}
			return Event;
		}

		/// <summary>
		/// Creates new event.
		/// </summary>
		/// <param name="eventDate">The date</param>
		/// <param name="musicType">The musicType</param>
		/// <param name="location">The location.</param>
		/// <param name="description">The description</param>
		/// <param name="tenantId">The tenant identifier.</param>
		/// <param name="name">The name.</param>
		/// <returns></returns>
		public IEventBuilder NewEvent(EventDate eventDate, MusicType musicType, Location location, string description, Guid tenantId, string name)
		{
			Event = new Event(eventDate, musicType, location, description, tenantId, name);

			return this;
		}

		/// <summary>
		/// Creates new eventidentifier.
		/// </summary>
		/// <param name="eventDate">The event date.</param>
		/// <param name="location">The location.</param>
		/// <param name="tenantId">The tenant identifier.</param>
		/// <returns></returns>
		public IEventBuilder NewEventIdentifier(EventDate eventDate, Location location, Guid tenantId)
		{
			Event = new Event(eventDate, location, tenantId);

			return this;
		}
	}
}