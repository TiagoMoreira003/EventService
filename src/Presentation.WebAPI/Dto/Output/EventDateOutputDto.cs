// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventDateOutputDto.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventDateOutputDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Dto.Output
{
	/// <summary>
	/// <see cref="EventDateOutputDto"/>
	/// </summary>
	public class EventDateOutputDto
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

		/// <summary>
		/// Gets the uu identifier.
		/// </summary>
		/// <value>
		/// The uu identifier.
		/// </value>
		public Guid UUId { get; init; }
	}
}