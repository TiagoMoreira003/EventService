namespace EventService.Domain.AggregateModels.Event
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using EventService.Domain.Exceptions;
	using EventService.Domain.SeedWork;

	public class Event : EntityBase, IAggregateRoot
	{
		public string Artist {get; private set;}
		public DateTime DateTime {get; private set;}

		public MusicType MusicType { get; private set;}

		public Location Location { get; private set;}

		public string Description { get; private set;}

		protected override IEnumerable<object> GetAtomicValues()
		{
			yield return this.UUId;
		}

		internal Event(string artist, DateTime dateTime, MusicType musicType, Location location, string Description) 
		{
			this.DateTime = dateTime;
			this.Artist = artist;
			this.MusicType = musicType;
			this.Location = location;
			this.Description = Description;
		}


	}
}