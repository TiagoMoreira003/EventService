// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddDetailsEventCommand.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// AddDetailsEventCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Commands.AddDetailsEventCommand
{
	using EventService.Domain.AggregateModels;
	using EventService.Domain.AggregateModels.Event;
	using EventService.Presentation.WebAPI.Dto.Input;
	using MediatR;

	/// <summary>
	///   <see cref="AddDetailsEventCommand" />
	/// </summary>
	/// <seealso cref="IRequest{Event}" />
	public class AddDetailsEventCommand : IRequest<Event>
	{
		/// <summary>
		/// Gets the address.
		/// </summary>
		/// <value>
		/// The address.
		/// </value>
		public AddressDto Address { get; init; }

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

		public Guid eventId { get; init; }

		/// <summary>
		/// Gets the location.
		/// </summary>
		/// <value>
		/// The location.
		/// </value>
		public LocationDto Location { get; init; }

		/// <summary>
		/// Gets the type of the music.
		/// </summary>
		/// <value>
		/// The type of the music.
		/// </value>
		public MusicType MusicType { get; init; }

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name { get; init; }
	}
}