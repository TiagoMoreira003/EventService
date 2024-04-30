// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationDto.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// LocationDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Dto.Input
{
	/// <summary>
	/// <see cref="LocationDto"/>
	/// </summary>
	public class LocationDto
	{
		/// <summary>
		/// Gets the address.
		/// </summary>
		/// <value>
		/// The address.
		/// </value>
		public AddressDto Address { get; init; }

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