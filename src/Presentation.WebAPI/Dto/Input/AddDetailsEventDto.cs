// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddDetailsDto.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// AddDetailsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using EventService.Domain.AggregateModels;

namespace EventService.Presentation.WebAPI.Dto.Input
{
	/// <summary>
	/// <see cref="AddDetailsDto"/>
	/// </summary>
	public class AddDetailsEventDto
	{
		public List<string> Artists { get; init; }

		public string Description { get; init; }

		/// <summary>
		/// Gets the date event.
		/// </summary>
		/// <value>
		/// The date event.
		/// </value>
		public EventDateDto EventDate { get; init; }

		public Guid EventId { get; init; }

		/// <summary>
		/// Gets the geo coordinates.
		/// </summary>
		/// <value>
		/// The geo coordinates.
		/// </value>
		public LocationDto Location { get; init; }

		public MusicType MusicType { get; init; }

		public string Name { get; init; }

		/// <summary>
		/// Gets the tenant identifier.
		/// </summary>
		/// <value>
		/// The tenant identifier.
		/// </value>
		public Guid TenantId { get; init; }
	}
}