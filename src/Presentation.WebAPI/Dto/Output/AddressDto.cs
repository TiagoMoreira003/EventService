// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressDto.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// AddressDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Dto.Output
{
	/// <summary>
	/// <see cref="AddressDto"/>
	/// </summary>
	public class AddressDto
	{
		/// <summary>
		/// Gets the postal code.
		/// </summary>
		/// <value>
		/// The postal code.
		/// </value>
		public string PostalCode { get; init; }

		/// <summary>
		/// Gets the state.
		/// </summary>
		/// <value>
		/// The state.
		/// </value>
		public string State { get; init; }

		/// <summary>
		/// Gets the street.
		/// </summary>
		/// <value>
		/// The street.
		/// </value>
		public string Street { get; init; }

		/// <summary>
		/// Gets the uu identifier.
		/// </summary>
		/// <value>
		/// The uu identifier.
		/// </value>
		public Guid UUId { get; init; }
	}
}