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
	using EventService.Presentation.WebAPI.Commands.CreateEventCommand;
	using EventService.Presentation.WebAPI.Dto.Input;
	using EventService.Presentation.WebAPI.Dto.Output;
	using EventService.Presentation.WebAPI.Utils;
	using MediatR;
	using Microsoft.AspNetCore.Mvc;
	using System.Net;

	/// <summary>
	/// <see cref="EventController"/>
	/// </summary>
	/// <seealso cref="Controller"/>
	[ApiController]
	[Route("api/v1/Event")]
	public class EventController : Controller
	{
		/// <summary>
		/// The mapper
		/// </summary>
		private readonly IMapper mapper;

		/// <summary>
		/// The mediator
		/// </summary>
		private readonly IMediator mediator;

		public EventController(
			IMapper mapper,
			IMediator mediator)
		{
			this.mapper = mapper;
			this.mediator = mediator;
		}

		/// <summary>
		/// Creates the team asynchronous.
		/// </summary>
		/// <param name="createEventDto">The create team dto.</param>
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
	}
}