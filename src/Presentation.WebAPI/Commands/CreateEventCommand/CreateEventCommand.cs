// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateEventCommand.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// CreateEventCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Commands.CreateEventCommand
{
	using EventService.Domain.AggregateModels.Event;
	using EventService.Presentation.WebAPI.Dto.Input;
	using MediatR;

	/// <summary>
	///   <see cref="CreateEventCommand" />
	/// </summary>
	/// <seealso cref="IRequest{Event}" />
	public class CreateEventCommand : IRequest<Event>
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