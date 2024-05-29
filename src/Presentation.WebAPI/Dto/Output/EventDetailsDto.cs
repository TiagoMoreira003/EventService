// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventDetailsDto.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventDetailsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Dto.Output
{
	using EventService.Domain.AggregateModels;

	/// <summary>
	/// <see cref="EventDetailsDto"/>
	/// </summary>
	public class EventDetailsDto
	{
		/// <summary>
		/// Gets the event date.
		/// </summary>
		/// <value>
		/// The event date.
		/// </value>
		public EventDateOutputDto EventDate { get; init; }

		/// <summary>
		/// Gets the location.
		/// </summary>
		/// <value>
		/// The location.
		/// </value>
		public LocationOutputDto Location { get; init; }

		/// <summary>
		/// Gets the type of the music.
		/// </summary>
		/// <value>
		/// The type of the music.
		/// </value>
		public MusicType MusicType { get; init; }

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

		/// <summary>
		/// Gets the artists.
		/// </summary>
		/// <value>
		/// The artists.
		/// </value>
		public List<string> Artists { get; init; }

		/// <summary>
		/// Gets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		public string Description { get; init; }

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name { get; init; }
	}
}