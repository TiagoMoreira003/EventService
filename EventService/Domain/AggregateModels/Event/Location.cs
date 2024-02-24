namespace EventService.Domain.AggregateModels
{
	using System;
	using System.Collections.Generic;
	using EventService.Domain.Exceptions;
	using EventService.Domain.SeedWork;
	public class Location : EntityBase
	{
		public string Latitud {get; private set;}
		public string Longitud {get; private set; }

		public Address Address {get; private set;}


		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return this.UUId;
		}

		internal Location(string latitud, string longitud, Address address) 
		{
			this.Latitud = latitud;
			this.Longitud = longitud;
			this.Address = address;
		}

	}
}
