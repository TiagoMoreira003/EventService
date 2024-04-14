// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateEventCommandHandler.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// CreateEventCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Commands.CreateEventCommand
{
	using EventService.Domain.AggregateModels;
	using EventService.Domain.AggregateModels.Event;
	using EventService.Domain.AggregateModels.Event.Builder.EventBuilder;
	using EventService.Domain.AggregateModels.Event.Builder.LocationBuilder;
	using EventService.Domain.AggregateModels.Event.Repository;
	using EventService.Domain.AggregateModels.Event.Repository.Models;
	using EventService.Domain.Exceptions;
	using MediatR;

	/// <summary>
	/// <see cref="CreateEventCommandHandler"/>
	/// </summary>
	/// <seealso cref="IRequestHandler{CreateEventCommand,Event}" />
	public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Event>
	{
		/// <summary>
		/// The event builder
		/// </summary>
		private readonly IEventBuilder eventBuilder;

		/// <summary>
		/// The event repository
		/// </summary>
		private readonly IEventRepository eventRepository;

		/// <summary>
		/// The location builder
		/// </summary>
		private readonly ILocationBuilder locationBuilder;

		/// <summary>
		/// The location repository
		/// </summary>
		private readonly ILocationRepository locationRepository;

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateEventCommandHandler"/> class.
		/// </summary>
		/// <param name="eventRepository">The event repository.</param>
		/// <param name="eventBuilder">The event builder.</param>
		public CreateEventCommandHandler(IEventRepository eventRepository, IEventBuilder eventBuilder)
		{
			this.eventRepository = eventRepository;
			this.eventBuilder = eventBuilder;
			this.locationBuilder = locationBuilder;
			this.locationRepository = locationRepository;
		}

		/// <summary>
		/// Handles a request
		/// </summary>
		/// <param name="request">The request</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>
		/// Response from the request
		/// </returns>
		/// <exception cref="DuplicatedException">The event with that owner, location and date is duplicated</exception>
		public async Task<Event> Handle(CreateEventCommand request, CancellationToken cancellationToken)
		{
			Event newevent = await this.eventRepository.GetByIdentifiersAsync(
				new GetByIdentifiersModel
				{
					TenantId = request.TenantId,
					EventDate = new EventDateModel
					{
						StartDate = request.EventDate.StartDate,
						EndDate = request.EventDate.EndDate
					},
					GeoCoordinates = new GeoCoordinatesModel
					{
						Latitude = request.GeoCoordinates.Latitude,
						Longitude = request.GeoCoordinates.Longitude
					}
				},
				cancellationToken);

			if (newevent is not null)
			{
				throw new DuplicatedException($"The event with that owner, location and date is duplicated");
			}

			var location = this.locationBuilder.NewLocationWithoutAddress(request.GeoCoordinates.Latitude, request.GeoCoordinates.Longitude).Build();

			newevent = this.eventBuilder.NewEventIdentifier(
				new EventDate(request.EventDate.StartDate, request.EventDate.EndDate),
				location,
				request.TenantId)
				.Build();

			await this.eventRepository.AddAsync(newevent, cancellationToken);

			await this.locationRepository.AddAsync(location, cancellationToken);

			await this.eventRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

			await this.locationRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

			return newevent;
		}
	}
}