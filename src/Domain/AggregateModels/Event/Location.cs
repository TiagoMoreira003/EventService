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
	using EventService.Domain.AggregateModels.Event.Repository.Models;
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

		public void AddAddress(AddressModel model)
		{
			this.Address.AddAdress(model);
		}

		/// <summary>
		/// Updates the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		public void Update(LocationModel model)
		{
			this.Longitude = model.Longitude;
			this.Latitude = model.Latitude;
			this.Address.UpdateAddress(model.Address.Street, model.Address.State, model.Address.PostalCode);
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