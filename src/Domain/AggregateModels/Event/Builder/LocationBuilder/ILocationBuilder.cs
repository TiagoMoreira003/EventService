// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILocationBuilder.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ILocationBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Builder.LocationBuilder
{
	/// <summary>
	///   <see cref="ILocationBuilder" />
	/// </summary>
	public interface ILocationBuilder
	{
		/// <summary>
		/// Builds this instance.
		/// </summary>
		/// <returns></returns>
		Location Build();

		/// <summary>
		/// Creates new location.
		/// </summary>
		/// <param name="latitude">The latitude.</param>
		/// <param name="longitude">The longitude.</param>
		/// <param name="address">The address.</param>
		/// <returns></returns>
		ILocationBuilder NewLocation(double latitude, double longitude, Address address);

		/// <summary>
		/// Creates new locationwithoutaddress.
		/// </summary>
		/// <param name="latitude">The latitude.</param>
		/// <param name="longitude">The longitude.</param>
		/// <returns></returns>
		ILocationBuilder NewLocationWithoutAddress(double latitude, double longitude);
	}
}