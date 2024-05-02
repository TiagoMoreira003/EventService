// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventDateModel.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventDateModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Repository.Models
{
	using System;

	/// <summary>
	///   <see cref="EventDateModel" />
	///   /// </summary>
	public class EventDateModel
	{
		/// <summary>
		/// Gets the end date.
		/// </summary>
		/// <value>
		/// The end date.
		/// </value>
		public DateTime EndDate { get; init; }

		/// <summary>
		/// Gets the start date.
		/// </summary>
		/// <value>
		/// The start date.
		/// </value>
		public DateTime StartDate { get; init; }
	}
}