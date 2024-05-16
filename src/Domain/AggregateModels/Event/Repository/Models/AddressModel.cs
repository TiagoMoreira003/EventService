// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressModel.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// AddressModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Repository.Models
{
	/// <summary>
	/// ~<see cref="AddressModel"/>
	/// </summary>
	public class AddressModel
	{
		/// <summary>
		/// Gets or sets the postal code.
		/// </summary>
		/// <value>
		/// The postal code.
		/// </value>
		public string PostalCode { get; init; }

		/// <summary>
		/// Gets or sets the state.
		/// </summary>
		/// <value>
		/// The state.
		/// </value>
		public string State { get; init; }

		/// <summary>
		/// Gets or sets the street.
		/// </summary>
		/// <value>
		/// The street.
		/// </value>
		public string Street { get; init; }
	}
}