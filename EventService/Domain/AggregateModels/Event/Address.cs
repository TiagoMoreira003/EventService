
namespace EventService.Domain.AggregateModels
{
	using System;
	using System.Collections.Generic;
	using EventService.Domain.Exceptions;
	using EventService.Domain.SeedWork;

	/// <summary>
	/// <see cref="Address"/>cref
	/// </summary>
	/// <seealso cref="ValueObject" />
	public class Address : ValueObject
	{

		/// <summary>
		/// Gets the street.
		/// </summary>
		/// <value>
		/// The street.
		/// </value>
		public string Street { get; private set; }

		/// <summary>
		/// Gets the state.
		/// </summary>
		/// <value>
		/// The state.
		/// </value>
		public string State { get; private set; }

		/// <summary>
		/// Gets the postalcode.
		/// </summary>
		/// <value>
		/// The postalcode.
		/// </value>
		public string PostalCode { get; private set; }


		/// <summary>
		/// Initializes a new instance of the <see cref="Address"/> class.
		/// </summary>
		/// <param name="street">The street.</param>
		/// <param name="state">The state.</param>
		/// <param name="postalcode">The postalcode.</param>
		public Address(string street, string state, string postalCode) 
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
