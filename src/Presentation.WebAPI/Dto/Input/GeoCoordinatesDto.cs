// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeoCoordinatesDto.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// GeoCoordinatesDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Dto.Input
{
	/// <summary>
	/// <see cref="GeoCoordinatesDto"/>
	/// </summary>
	public class GeoCoordinatesDto
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