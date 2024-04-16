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
		/// <param name="eventDate">The date.</param>
		/// <param name="musicType">Type of the music.</param>
		/// <param name="location">The location.</param>
		/// <param name="description">The description.</param>
		/// <param name="tenantId">The tenant identifier.</param>
		/// <param name="name">The name.</param>
		internal Event(EventDate eventDate, MusicType musicType, Location location, string description, Guid tenantId, string name)
			: this()
		{
			this.EventDate = eventDate;
			this.MusicType = musicType;
			this.Location = location;
			this.Description = description;
			this.TenantId = tenantId;
			this.Name = name;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Event"/> class.
		/// </summary>
		/// <param name="eventDate">The event date.</param>
		/// <param name="location">The location.</param>
		/// <param name="tenantId">The tenant identifier.</param>
		internal Event(EventDate eventDate, Location location, Guid tenantId)
			: this()
		{
			this.EventDate = eventDate;
			this.Location = location;
			this.TenantId = tenantId;
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
		/// Gets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		public string Description { get; private set; }

		/// <summary>
		/// Gets the date time.
		/// </summary>
		/// <value>
		/// The date time.
		/// </value>
		public EventDate EventDate { get; private set; }

		/// <summary>
		/// Gets the location.
		/// </summary>
		/// <value>
		/// The location.
		/// </value>
		public Location Location { get; private set; }

		/// <summary>
		/// Gets the type of the music.
		/// </summary>
		/// <value>
		/// The type of the music.
		/// </value>
		public MusicType MusicType { get; private set; }

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name { get; private set; }

		/// <summary>
		/// Gets the tenant identifier.
		/// </summary>
		/// <value>
		/// The tenant identifier.
		/// </value>
		public Guid TenantId { get; private set; }

		/// <summary>
		/// Adds the artists.
		/// </summary>
		/// <param name="artist">Name of the artist.</param>
		/// <exception cref="ArgumentNullException">artist - The Artist is null.</exception>
		/// <exception cref="DuplicatedException">The Artist {artist} already exists.</exception>

		public void AddArtist(string artist)
		{
			if (string.IsNullOrEmpty(artist))
			{
				throw new ArgumentNullException(nameof(artist), "The artist name is null.");
			}

			if (this.ArtistExists(artist))
			{
				throw new DuplicatedException($"The Artist {artist} already exists.");
			}

			this.artists.Add(artist);
		}

		/// <summary>
		/// Adds the details.
		/// </summary>
		/// <param name="musicType">Type of the music.</param>
		/// <param name="description">The description.</param>
		/// <param name="name">The name.</param>
		public void AddDetails(MusicType musicType, string description, string name, Address address)
		{
			this.MusicType = musicType;
			this.Description = description;
			this.Name = name;
			this.Location.AddAddress(address);
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

		private bool ArtistExists(string artist)
		{
			return this.artists.Exists(x => x == artist);
		}
	}
}