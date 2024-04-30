// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddDetailsEventCommandHandler.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// AddDetailsEventCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Commands.AddDetailsEventCommand
{
	using EventService.Domain.AggregateModels;
	using EventService.Domain.AggregateModels.Event;
	using EventService.Domain.AggregateModels.Event.Repository;
	using EventService.Domain.Exceptions;
	using MediatR;

	/// <summary>
	/// <see cref="AddDetailsEventCommandHandler"/>
	/// </summary>
	/// <seealso cref="IRequestHandler{AddDetailsEventCommand,Event}" />
	public class AddDetailsEventCommandHandler : IRequestHandler<AddDetailsEventCommand, Event>
	{
		/// <summary>
		/// The event repository
		/// </summary>
		private readonly IEventRepository eventRepository;

		/// <summary>
		/// Initializes a new instance of the <see cref="AddDetailsEventCommandHandler"/> class.
		/// </summary>
		/// <param name="eventRepository">The event repository.</param>
		/// <param name="locationRepository">The location repository.</param>
		public AddDetailsEventCommandHandler(IEventRepository eventRepository)
		{
			this.eventRepository = eventRepository;
		}

		public async Task<Event> Handle(AddDetailsEventCommand request, CancellationToken cancellationToken)
		{
			Event existingEvent = await this.eventRepository.GetAsync(request.EventId, cancellationToken);

			if (existingEvent is null)
			{
				throw new NotFoundException($"The event with {request.EventId} does not exist");
			}

			existingEvent.AddDetails(
				request.MusicType,
				request.Description,
				request.Name,
				new Address(
					request.Location.Address.Street,
					request.Location.Address.State,
					request.Location.Address.PostalCode));

			foreach (string artist in request.Artists)
			{
				existingEvent.AddArtist(artist);
			}

			await this.eventRepository.Update(existingEvent, cancellationToken);

			await this.eventRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

			return existingEvent;
		}
	}
}