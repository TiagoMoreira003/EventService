// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Date.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// Address
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Domain.AggregateModels
{
	using EventService.Domain.SeedWork;
	using System;
	using System.Collections.Generic;

	/// <summary>
	///   <see cref="Date" />
	/// </summary>
	/// <seealso cref="ValueObject" />
	public class Date : ValueObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Address" /> class.
		/// </summary>
		/// <param name="startDate">The startdate.</param>
		/// <param name="endDate">The enddate.</param>
		public Date(DateTime startDate, DateTime endDate)
		{
			this.StartDate = startDate;
			this.EndDate = endDate;
		}

		/// <summary>
		/// Gets the street.
		/// </summary>
		/// <value>
		/// The street.
		/// </value>
		public DateTime EndDate { get; private set; }

		/// <summary>
		/// Gets the state.
		/// </summary>
		/// <value>
		/// The state.
		/// </value>
		public DateTime StartDate { get; private set; }

		/// <summary>
		/// Gets the atomic values.
		/// </summary>
		/// <returns></returns>
		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return this.StartDate;
			yield return this.EndDate;
		}
	}
}