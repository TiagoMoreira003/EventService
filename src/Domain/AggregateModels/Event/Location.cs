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
		/// Gets the atomic values.
		/// </summary>
		/// <returns></returns>
		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return this.UUId;
		}
	}
}