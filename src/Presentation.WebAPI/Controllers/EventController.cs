// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventController.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Controllers
{
	using AutoMapper;
	using EventService.Domain.AggregateModels.Event;
	using EventService.Presentation.WebAPI.Commands.AddDetailsEventCommand;
	using EventService.Presentation.WebAPI.Commands.CreateEventCommand;
	using EventService.Presentation.WebAPI.Commands.DeleteEventCommand;
	using EventService.Presentation.WebAPI.Commands.UpdateEventCommand;
	using EventService.Presentation.WebAPI.Dto.Input;
	using EventService.Presentation.WebAPI.Dto.Input.UpdateEventDto;
	using EventService.Presentation.WebAPI.Dto.Output;
	using EventService.Presentation.WebAPI.Query.GetAllActiveEventsQuery;
	using EventService.Presentation.WebAPI.Query.ReadEventCommand;
	using EventService.Presentation.WebAPI.Utils;
	using MediatR;
	using Microsoft.AspNetCore.Mvc;
	using System.Net;

	/// <summary>
	/// <see cref="EventController" />
	/// </summary>
	/// <seealso cref="Controller" />
	[ApiController]
	[Route("api/v1/Event")]
	public class EventController : Controller
	{
		private readonly ILogger<EventController> _logger;

		/// <summary>
		/// The mapper
		/// </summary>
		private readonly IMapper mapper;

		/// <summary>
		/// The mediator
		/// </summary>
		private readonly IMediator mediator;

		/// <summary>
		/// Initializes a new instance of the <see cref="EventController"/> class.
		/// </summary>
		/// <param name="mapper">The mapper.</param>
		/// <param name="mediator">The mediator.</param>
		public EventController(
			IMapper mapper,
			IMediator mediator,
			ILogger<EventController> logger)
		{
			this.mapper = mapper;
			this.mediator = mediator;
			this._logger = logger;
		}

		/// <summary>
		/// Adds the details event asynchronous.
		/// </summary>
		/// <param name="eventId">The event identifier.</param>
		/// <param name="addDetailsEventDto">The add details event dto.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		[HttpPut("{eventId}")]
		[ProducesResponseType(typeof(EventDetailsDto), (int)HttpStatusCode.OK)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.InternalServerError)]
		public async Task<IActionResult> AddDetailsEventAsync([FromRoute] Guid eventId, [FromForm] AddDetailsEventDto addDetailsEventDto, CancellationToken cancellationToken)
		{
			_logger.LogInformation(addDetailsEventDto.Image.ContentType);
			_logger.LogInformation(addDetailsEventDto.Image.FileName);

			Event eventDetails = await this.mediator.Send(new AddDetailsEventCommand
			{
				MusicType = addDetailsEventDto.MusicType,
				Description = addDetailsEventDto.Description,
				Name = addDetailsEventDto.Name,
				Artists = addDetailsEventDto.Artists,
				Address = new AddressDto
				{
					Street = addDetailsEventDto.Address.Street,
					State = addDetailsEventDto.Address.State,
					PostalCode = addDetailsEventDto.Address.PostalCode,
				},
				EventId = eventId,
				Image = addDetailsEventDto.Image,
			}, cancellationToken);

			return this.Ok(this.mapper.Map<EventDetailsDto>(eventDetails));
		}

		/// <summary>
		/// Creates the event asynchronous.
		/// </summary>
		/// <param name="createEventDto">The create event dto.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		[HttpPost]
		[ProducesResponseType(typeof(EventDto), (int)HttpStatusCode.OK)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.InternalServerError)]
		public async Task<IActionResult> CreateEventAsync([FromBody] CreateEventDto createEventDto, CancellationToken cancellationToken)
		{
			Event newevent = await this.mediator.Send(new CreateEventCommand
			{
				TenantId = createEventDto.TenantId,
				EventDate = new EventDateDto
				{
					StartDate = createEventDto.EventDate.StartDate,
					EndDate = createEventDto.EventDate.EndDate,
				},
				GeoCoordinates = new GeoCoordinatesDto
				{
					Latitude = createEventDto.GeoCoordinates.Latitude,
					Longitude = createEventDto.GeoCoordinates.Longitude,
				},
			},
			cancellationToken);

			return this.Ok(this.mapper.Map<EventDto>(newevent));
		}

		/// <summary>
		/// Deletes the event asynchronous.
		/// </summary>
		/// <param name="filters">The filters.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		[HttpDelete("{EventId}")]
		[ProducesResponseType((int)HttpStatusCode.OK)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.InternalServerError)]
		public async Task<IActionResult> DeleteEventAsync([FromRoute] GetByEventIdDto filters, CancellationToken cancellationToken)
		{
			await this.mediator.Publish(new DeleteEventCommand
			{
				EventId = filters.EventId,
			}, cancellationToken);

			return this.Ok();
		}

		/// <summary>
		/// Gets all active events.
		/// </summary>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		[HttpGet("events")]
		[ProducesResponseType((int)HttpStatusCode.OK)]
		[ProducesResponseType(typeof(IEnumerable<EventPoint>), (int)HttpStatusCode.OK)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.InternalServerError)]
		public async Task<IActionResult> GetAllActiveEvents(CancellationToken cancellationToken)
		{
			IEnumerable<Event> events = await this.mediator.Send(new GetAllActiveEventsQuery(), cancellationToken);

			return this.Ok(this.mapper.Map<IEnumerable<EventPoint>>(events));
		}

		/// <summary>
		/// Reads the event asynchronous.
		/// </summary>
		/// <param name="filters">The filters.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		[HttpGet("{EventId}")]
		[ProducesResponseType((int)HttpStatusCode.OK)]
		[ProducesResponseType(typeof(EventDetailsDto), (int)HttpStatusCode.OK)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.InternalServerError)]
		public async Task<IActionResult> ReadEventAsync([FromRoute] GetByEventIdDto filters, CancellationToken cancellationToken)
		{
			var eventDetails = await this.mediator.Send(new ReadEventQuery
			{
				EventId = filters.EventId
			}, cancellationToken);

			return this.Ok(this.mapper.Map<EventDetailsDto>(eventDetails));
		}

		/// <summary>
		/// Updates the event asynchronous.
		/// </summary>
		/// <param name="EventId">The event identifier.</param>
		/// <param name="updateEventDto">The update event dto.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns></returns>
		[HttpPut("{EventId}/update")]
		[ProducesResponseType((int)HttpStatusCode.OK)]
		[ProducesResponseType(typeof(EventDetailsDto), (int)HttpStatusCode.OK)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
		[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.InternalServerError)]
		public async Task<IActionResult> UpdateEventAsync([FromRoute] Guid EventId, [FromForm] UpdateEventDto updateEventDto, CancellationToken cancellationToken)
		{
			Event existingEvent = await this.mediator.Send(new UpdateEventCommand
			{
				EventId = EventId,
				Name = updateEventDto.Name,
				Description = updateEventDto.Description,
				EventDate = new EventDateDto
				{
					StartDate = updateEventDto.EventDate.StartDate,
					EndDate = updateEventDto.EventDate.EndDate
				},
				Location = new LocationDto
				{
					Latitude = updateEventDto.Location.Latitude,
					Longitude = updateEventDto.Location.Longitude,
					Address = new AddressDto
					{
						Street = updateEventDto.Location.Address.Street,
						State = updateEventDto.Location.Address.State,
						PostalCode = updateEventDto.Location.Address.PostalCode
					}
				},
				MusicType = updateEventDto.MusicType,
				Artists = updateEventDto.Artists,
				Image = updateEventDto.Image,
			}, cancellationToken);

			return this.Ok(this.mapper.Map<EventDetailsDto>(existingEvent));
		}
	}
}