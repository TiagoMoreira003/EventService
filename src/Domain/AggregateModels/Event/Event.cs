// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Event.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// Event
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Domain.AggregateModels.Event
{
	using EventService.Domain.SeedWork;
	using System.Collections.Generic;

	/// <summary>
	///   <see cref="Event" />
	/// </summary>
	/// <seealso cref="EntityBase" />
	/// <seealso cref="IAggregateRoot" />
	public class Event : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Event" /> class.
		/// </summary>
		/// <param name="artists">The artists.</param>
		/// <param name="date">The date.</param>
		/// <param name="musicType">Type of the music.</param>
		/// <param name="location">The location.</param>
		/// <param name="description">The description.</param>
		internal Event(List<string> artists, Date date, MusicType musicType, Location location, string description)
			: this()
		{
			this.Date = date;
			this.Artists = artists;
			this.MusicType = musicType;
			this.Location = location;
			this.Description = description;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Event" /> class.
		/// </summary>
		protected Event()
			: base()
		{
		}

		/// <summary>
		/// Gets the artist.
		/// </summary>
		/// <value>
		/// The artist.
		/// </value>
		public List<string> Artists { get; private set; }

		/// <summary>
		/// Gets the date time.
		/// </summary>
		/// <value>
		/// The date time.
		/// </value>
		public Date Date { get; private set; }

		/// <summary>
		/// Gets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		public string Description { get; private set; }

		/// <summary>
		/// Gets the location.
		/// </summary>
		/// <value>
		/// The location.
		/// </value>
		public virtual Location Location { get; private set; }

		/// <summary>
		/// Gets the type of the music.
		/// </summary>
		/// <value>
		/// The type of the music.
		/// </value>
		public MusicType MusicType { get; private set; }

		/// <summary>
		/// Gets the atomic values.
		/// </summary>
		/// <returns></returns>
		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return this.UUId;
		}
	}
}