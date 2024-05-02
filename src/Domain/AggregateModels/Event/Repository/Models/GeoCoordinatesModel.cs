// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeoCoordinatesModel.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// GeoCoordinatesModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Repository.Models
{
	/// <summary>
	/// ~<see cref="GeoCoordinatesModel"/>
	/// </summary>
	public class GeoCoordinatesModel
	{
		/// <summary>
		/// Gets the latitude.
		/// </summary>
		/// <value>
		/// The latitude.
		/// </value>
		public double Latitude { get; init; }

		/// <summary>
		/// Gets the longitude.
		/// </summary>
		/// <value>
		/// The longitude.
		/// </value>
		public double Longitude { get; init; }
	}
}