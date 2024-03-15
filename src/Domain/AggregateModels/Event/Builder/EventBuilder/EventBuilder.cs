﻿// --------------------------------------------------------------------------------------------------------------------
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

	/// <summary>
	///   <see cref="IEventBuilder" />
	/// </summary>
	/// <seealso cref="IEventBuilder" />

	internal class EventBuilder : IEventBuilder
	{
		/// <summary>
		/// The team
		/// </summary>
		private Event Event;

		/// <summary>
		/// Builds this instance.
		/// </summary>
		/// <returns></returns>
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
		/// <param name="dateTime"></param>
		/// <param name="artist">The acronym.</param>
		/// <param name="musicType"></param>
		/// <param name="location">The acronym.</param>
		/// <param name="description"></param>
		/// <returns></returns>
		public IEventBuilder NewEvent(string artist, DateTime dateTime, MusicType musicType, Location location, string description)
		{
			Event = new Event(artist, dateTime, musicType, location, description);

			return this;
		}
	}
}