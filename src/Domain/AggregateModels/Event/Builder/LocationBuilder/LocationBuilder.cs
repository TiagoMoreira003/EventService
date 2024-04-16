// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationBuilder.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// LocationBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Builder.LocationBuilder
{
	using System;

	/// <summary>
	///   <see cref="LocationBuilder" />
	/// </summary>
	/// <seealso cref="ILocationBuilder" />
	internal class LocationBuilder : ILocationBuilder
	{
		/// <summary>
		/// The location
		/// </summary>
		private Location location;

		/// <summary>
		/// Builds this instance.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="System.InvalidOperationException">The location object is not initialized.</exception>
		public Location Build()
		{
			if (location is null)
			{
				throw new InvalidOperationException("The location object is not initialized.");
			}
			return location;
		}

		// <summary>
		/// <summary>
		/// Creates new location.
		/// </summary>
		/// <param name="latitude">The latitude.</param>
		/// <param name="longitude">The longitude.</param>
		/// <param name="address">The address.</param>
		/// <returns></returns>
		public ILocationBuilder NewLocation(double latitude, double longitude, Address address)
		{
			location = new Location(latitude, longitude, address);

			return this;
		}

		/// <summary>
		/// Creates new locationwithoutaddress.
		/// </summary>
		/// <param name="latitude">The latitude.</param>
		/// <param name="longitude">The longitude.</param>
		/// <returns></returns>
		public ILocationBuilder NewLocationWithoutAddress(double latitude, double longitude)
		{
			location = new Location(latitude, longitude);

			return this;
		}
	}
}