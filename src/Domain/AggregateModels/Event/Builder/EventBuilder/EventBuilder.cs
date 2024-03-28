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
	/// <see cref="EventBuilder" />
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
		/// <param name="date">The date</param>
		/// <param name="musicType">The musicType</param>
		/// <param name="location">The location.</param>
		/// <param name="description">The description</param>
		/// <returns></returns>
		public IEventBuilder NewEvent(Date date, MusicType musicType, Location location, string description)
		{
			Event = new Event(date, musicType, location, description);

			return this;
		}
	}
}