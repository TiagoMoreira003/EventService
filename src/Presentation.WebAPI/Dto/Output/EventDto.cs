// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventDto.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Dto.Output
{
	/// <summary>
	/// <see cref="EventDto"/>
	/// </summary>
	public class EventDto
	{
		/// <summary>
		/// Gets the date event.
		/// </summary>
		/// <value>
		/// The date event.
		/// </value>
		public EventDateOutputDto EventDate { get; init; }

		/// <summary>
		/// Gets the geo coordinates.
		/// </summary>
		/// <value>
		/// The geo coordinates.
		/// </value>
		public LocationDto Location { get; init; }

		/// <summary>
		/// Gets the tenant identifier.
		/// </summary>
		/// <value>
		/// The tenant identifier.
		/// </value>
		public Guid TenantId { get; init; }

		/// <summary>
		/// Gets the uu identifier.
		/// </summary>
		/// <value>
		/// The uu identifier.
		/// </value>
		public Guid UUId { get; init; }
	}
}