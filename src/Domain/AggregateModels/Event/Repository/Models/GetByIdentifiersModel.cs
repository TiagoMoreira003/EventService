// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByIdentifiersModel.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// GetByIdentifiersModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Repository.Models
{
	using System;

	/// <summary>
	///   <see cref="GetByIdentifiersModel" />
	/// </summary>
	public class GetByIdentifiersModel
	{
		/// <summary>
		/// Gets the date event.
		/// </summary>
		/// <value>
		/// The date event.
		/// </value>
		public EventDateModel EventDate { get; init; }

		/// <summary>
		/// Gets the geo coordinates.
		/// </summary>
		/// <value>
		/// The geo coordinates.
		/// </value>
		public GeoCoordinatesModel GeoCoordinates { get; init; }

		/// <summary>
		/// Gets the tenant identifier.
		/// </summary>
		/// <value>
		/// The tenant identifier.
		/// </value>
		public Guid TenantId { get; init; }
	}
}