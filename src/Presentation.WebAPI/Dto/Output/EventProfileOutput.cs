// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventProfileOutput.cs" company="KROWN">
// Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventProfileOutput
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Presentation.WebAPI.Dto.Output
{
	/// <summary>
	/// <see cref="EventProfileOutput" />
	/// </summary>
	public class EventProfileOutput
	{
		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name { get; init; }
		/// <summary>
		/// Gets the location.
		/// </summary>
		/// <value>
		/// The location.
		/// </value>
		public LocationOutputDto Location { get; init; }

		/// <summary>
		/// Gets the uu identifier.
		/// </summary>
		/// <value>
		/// The uu identifier.
		/// </value>
		public Guid UUId { get; init; }
	}
}
