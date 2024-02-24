// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamBuilder.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// TeamBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

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
		private Location Location;

		/// <summary>
		/// Builds this instance.
		/// </summary>
		/// <returns></returns>
		public Location Build()
		{
			return this.Location;
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
			this.Location = new Location(latitud, longitud, address);

			return this;
		}
	}
}