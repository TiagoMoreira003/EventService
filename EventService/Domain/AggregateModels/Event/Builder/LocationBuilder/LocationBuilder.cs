// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Location.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// Location
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace EventService.Domain.AggregateModels.Event.Builder.LocationBuilder
{
	/// <summary>
	///   <see cref="LocationBuilder" />
	/// </summary>
	/// <seealso cref="ILocationBuilder" />
	internal class LocationBuilder : ILocationBuilder
	{
		/// <summary>
		/// The team
		/// </summary>
		private Location location;

		/// <summary>
		/// Builds this instance.
		/// </summary>
		/// <returns></returns>
		public Location Build()
		{
			if (location is null)
			{
				throw new InvalidOperationException("The event object is not initialized.");
			}
			return location;
		}

		// <summary>
		/// Creates new eventlocation.
		/// </summary>
		/// <param name="latitud"></param>
		/// <param name="longitud"></param>
		/// <param name="address"></param>
		/// <returns></returns>
		public ILocationBuilder NewLocation(string latitud, string longitud, Address address)
		{
			location = new Location(latitud, longitud, address);

			return this;
		}
	}
}