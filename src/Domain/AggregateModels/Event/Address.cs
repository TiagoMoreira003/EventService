// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Address.cs" company="KROWN">
// Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// Address
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Domain.AggregateModels
{
	using EventService.Domain.SeedWork;
	using System.Collections.Generic;

	/// <summary>
	/// <see cref="Address"/>cref
	/// </summary>
	/// <seealso cref="ValueObject" />
	public class Address : ValueObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Address"/> class.
		/// </summary>
		/// <param name="street">The street.</param>
		/// <param name="state">The state.</param>
		/// <param name="postalCode">The postalcode.</param>
		public Address(string street, string state, string postalCode)
		{
			this.Street = street;
			this.State = state;
			this.PostalCode = postalCode;
		}

		/// <summary>
		/// Gets the postalcode.
		/// </summary>
		/// <value>
		/// The postalcode.
		/// </value>
		public string PostalCode { get; private set; }

		/// <summary>
		/// Gets the state.
		/// </summary>
		/// <value>
		/// The state.
		/// </value>
		public string State { get; private set; }

		/// <summary>
		/// Gets the street.
		/// </summary>
		/// <value>
		/// The street.
		/// </value>
		public string Street { get; private set; }

		/// <summary>
		/// Updates the specified street.
		/// </summary>
		/// <param name="street">The street.</param>
		/// <param name="state">The state.</param>
		/// <param name="postalCode">The postal code.</param>
		public void Update(string street, string state, string postalCode)
		{
			this.Street = street;
			this.State = state;
			this.PostalCode = postalCode;
		}

		/// <summary>
		/// Gets the atomic values.
		/// </summary>
		/// <returns></returns>
		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return this.Street;
			yield return this.State;
			yield return this.PostalCode;
		}
	}
}