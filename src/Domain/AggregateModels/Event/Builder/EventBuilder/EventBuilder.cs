// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventBuilder.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace EventService.Domain.AggregateModels.Event.Builder.EventBuilder
{
	/// <summary>
	///   <see cref="EventBuilder" />
	/// </summary>
	/// <seealso cref="IEventBuilder" />

	internal class EventBuilder : IEventBuilder
	{
		/// <summary>
		/// The event
		/// </summary>
		private Event Event;

		/// <summary>
		/// Builds this instance.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="System.InvalidOperationException">The event object is not initialized.</exception>
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