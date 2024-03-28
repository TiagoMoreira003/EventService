// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Event.cs" company="KROWN">
// Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// Event
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Domain.AggregateModels.Event
{
	using EventService.Domain.Exceptions;
	using EventService.Domain.SeedWork;
	using System;
	using System.Collections.Generic;

	/// <summary>
	///   <see cref="Event" />
	/// </summary>
	/// <seealso cref="EntityBase" />
	/// <seealso cref="IAggregateRoot" />
	public class Event : EntityBase, IAggregateRoot
	{
		/// <summary>
		/// The artists
		/// </summary>
		private readonly List<string> artists;

		/// <summary>
		/// Initializes a new instance of the <see cref="Event" /> class.
		/// </summary>
		/// <param name="date">The date.</param>
		/// <param name="musicType">Type of the music.</param>
		/// <param name="location">The location.</param>
		/// <param name="description">The description.</param>
		internal Event(Date date, MusicType musicType, Location location, string description)
			: this()
		{
			this.Date = date;
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
			this.artists = new List<string>();
		}

		/// <summary>
		/// Gets the artists.
		/// </summary>
		/// <value>
		/// The artists.
		/// </value>
		public virtual IReadOnlyCollection<string> Artists => this.artists;

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
		/// Adds the artists.
		/// </summary>
		/// <param name="artistName">Name of the artist.</param>
		/// <exception cref="ArgumentNullException">artists - The Artists is null.</exception>
		/// <exception cref="DuplicatedException">The Artist {artists} already exists.</exception>
		//public void AddArtist(string artists)
		//{
		//	if (string.IsNullOrEmpty(artists))
		//	{
		//		throw new ArgumentNullException(nameof(artists), "The Artists is null.");
		//	}

		//	if (this.ArtistExists(artistName))
		//	{
		//		throw new DuplicatedException($"The Artist {artists} already exists.");
		//	}

		//	this.artists.Add(artists);
		//}

		public void AddArtist(string artistName)
		{
			if (string.IsNullOrEmpty(artistName))
			{
				throw new ArgumentNullException(nameof(artistName), "The artist name is null.");
			}

			if (this.ArtistExists(artistName))
			{
				throw new DuplicatedException($"The Artist {artistName} already exists.");
			}

			this.artists.Add(artistName);
		}

		/// <summary>
		/// Gets the atomic values.
		/// </summary>
		/// <returns></returns>
		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return this.UUId;
		}

		/// <summary>
		/// Artists the exists.
		/// </summary>
		/// <param name="artist">The artist.</param>
		/// <returns></returns>
		//private bool ArtistExists(string artists)
		//{
		//	return this.artists.Exists(x => x.Artists == artists);
		//}

		private bool ArtistExists(string artist)
		{
			// Assumindo que this.artists é uma List<string>
			return this.artists.Exists(x => x == artist);
		}
	}
}