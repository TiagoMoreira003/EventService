// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Domain.AggregateModels
{
	using EventService.Domain.SeedWork;
	using System.Collections.Generic;

	/// <summary>
	/// <see cref="Location"/>
	/// </summary>
	/// <seealso cref="EntityBase" />
	public class Location : EntityBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Location"/> class.
		/// </summary>
		/// <param name="latitud">The latitud.</param>
		/// <param name="longitud">The longitud.</param>
		/// <param name="address">The address.</param>
		internal Location(string latitud, string longitud, Address address)
		{
			this.Latitud = latitud;
			this.Longitud = longitud;
			this.Address = address;
		}

		/// <summary>
		/// Gets the address.
		/// </summary>
		/// <value>
		/// The address.
		/// </value>
		public Address Address { get; private set; }

		/// <summary>
		/// Gets the latitud.
		/// </summary>
		/// <value>
		/// The latitud.
		/// </value>
		public string Latitud { get; private set; }

		/// <summary>
		/// Gets the longitud.
		/// </summary>
		/// <value>
		/// The longitud.
		/// </value>
		public string Longitud { get; private set; }

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