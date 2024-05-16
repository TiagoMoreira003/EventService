// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Location.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// Location
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Domain.AggregateModels.Event
{
	using EventService.Domain.SeedWork;
	using System.Collections.Generic;

	/// <summary>
	///   <see cref="Location" />
	/// </summary>
	/// <seealso cref="EntityBase" />
	public class Location : EntityBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Location" /> class.
		/// </summary>
		/// <param name="latitude">The latitude.</param>
		/// <param name="longitude">The longitude.</param>
		/// <param name="address">The address.</param>
		internal Location(double latitude, double longitude, Address address)
			: this()
		{
			this.Latitude = latitude;
			this.Longitude = longitude;
			this.Address = address;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Location"/> class.
		/// </summary>
		/// <param name="latitude">The latitude.</param>
		/// <param name="longitude">The longitude.</param>
		internal Location(double latitude, double longitude)
			: this()
		{
			this.Latitude = latitude;
			this.Longitude = longitude;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Location" /> class.
		/// </summary>
		protected Location()
			: base()
		{
		}

		/// <summary>
		/// Gets the address.
		/// </summary>
		/// <value>
		/// The address.
		/// </value>
		public Address Address { get; private set; }

		/// <summary>
		/// Gets the latitude.
		/// </summary>
		/// <value>
		/// The latitude.
		/// </value>
		public double Latitude { get; private set; }

		/// <summary>
		/// Gets the longitude.
		/// </summary>
		/// <value>
		/// The longitude.
		/// </value>
		public double Longitude { get; private set; }

		/// <summary>
		/// Adds the address.
		/// </summary>
		/// <param name="address">The address.</param>
		public void AddAddress(Address address)
		{
			this.Address = address;
		}

		/// <summary>
		/// Updates the specified longitude.
		/// </summary>
		/// <param name="longitude">The longitude.</param>
		/// <param name="latitude">The latitude.</param>
		/// <param name="street">The street.</param>
		/// <param name="state">The state.</param>
		/// <param name="postalCode">The postal code.</param>
		public void Update(double longitude, double latitude, string street, string state, string postalCode)
		{
			this.Longitude = longitude;
			this.Latitude = latitude;
			this.Address.Update(street, state, postalCode);
		}

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