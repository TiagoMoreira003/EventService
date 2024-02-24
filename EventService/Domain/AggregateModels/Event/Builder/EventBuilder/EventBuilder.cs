// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamBuilder.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// TeamBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Builder.EventBuilder
{
	using System;
	using System.Globalization;


	/// <summary>
	/// <see cref="IEventBuilder"/>
	/// </summary>
	/// <seealso cref="IEventBuilder"/>
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
			return this.Event;
		}


		public IEventBuilder NewEvent(DateTime dateTime, string artist, MusicType musicType, Location location, string description)
		{
			this.Event = new Event(artist, dateTime, musicType, location, description);

			return this;
		}


	}
}