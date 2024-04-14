// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventDateDto.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventDateDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Dto.Input
{
	/// <summary>
	/// <see cref="EventDateDto"/>
	/// </summary>
	public class EventDateDto
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