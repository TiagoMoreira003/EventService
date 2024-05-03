// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AllPropertiesModel.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// AllPropertiesModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Repository.Models
{
	using System.Collections.Generic;

	/// <summary>
	///   <see cref="AllPropertiesModel" />
	/// </summary>
	public class AllPropertiesModel
	{
		/// <summary>
		/// Gets the artists.
		/// </summary>
		/// <value>
		/// The artists.
		/// </value>
		public List<string> Artists { get; init; }

		/// <summary>
		/// Gets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		public string Description { get; init; }

		/// <summary>
		/// Gets the date event.
		/// </summary>
		/// <value>
		/// The date event.
		/// </value>
		public EventDateModel EventDate { get; init; }

		/// <summary>
		/// Gets the location.
		/// </summary>
		/// <value>
		/// The location.
		/// </value>
		public LocationModel Location { get; init; }

		/// <summary>
		/// Gets the type of the music.
		/// </summary>
		/// <value>
		/// The type of the music.
		/// </value>
		public MusicType MusicType { get; init; }

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name { get; init; }
	}
}