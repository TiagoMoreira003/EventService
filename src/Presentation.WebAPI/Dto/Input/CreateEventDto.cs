// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateEventDto.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// CreateEventDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Dto.Input
{
	/// <summary>
	/// <see cref="CreateEventDto"/>
	/// </summary>
	public class CreateEventDto
	{
		/// <summary>
		/// Gets the date event.
		/// </summary>
		/// <value>
		/// The date event.
		/// </value>
		public EventDateDto EventDate { get; init; }

		/// <summary>
		/// Gets the geo coordinates.
		/// </summary>
		/// <value>
		/// The geo coordinates.
		/// </value>
		public GeoCoordinatesDto GeoCoordinates { get; init; }

		/// <summary>
		/// Gets the tenant identifier.
		/// </summary>
		/// <value>
		/// The tenant identifier.
		/// </value>
		public Guid TenantId { get; init; }
	}
}