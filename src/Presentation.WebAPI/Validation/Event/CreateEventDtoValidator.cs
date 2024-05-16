// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateEventDtoValidator.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// CreateEventDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Presentation.WebAPI.Validation.Event
{
	using EventService.Presentation.WebAPI.Dto.Input;
	using FluentValidation;

	/// <summary>
	/// <see cref="CreateEventDtoValidator"/>
	/// </summary>
	/// <seealso cref="AbstractValidator{CreateEventDto}" />
	public class CreateEventDtoValidator : AbstractValidator<CreateEventDto>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateEventDtoValidator"/> class.
		/// </summary>
		public CreateEventDtoValidator()
		{
			RuleFor(x => x.EventDate)
				.NotNull();

			RuleFor(x => x.EventDate.StartDate)
				.NotNull()
					.WithMessage("StartDate is required");

			RuleFor(x => x.EventDate.EndDate)
				.NotNull()
					.WithMessage("EndDate is required");

			RuleFor(x => x.EventDate.StartDate)
				.GreaterThan(DateTime.Now)
					.WithMessage("Events can't happen in past");

			RuleFor(x => x.EventDate.EndDate)
				.GreaterThan(x => x.EventDate.StartDate)
					.WithMessage("The events can't open in the following day and close in the days before");

			RuleFor(x => x.GeoCoordinates)
				.NotNull()
					.WithMessage("GeoCoordinates is required");

			RuleFor(x => x.GeoCoordinates.Latitude)
				.NotEmpty()
					.WithMessage("Latitude is required");

			RuleFor(x => x.GeoCoordinates.Longitude)
				.NotEmpty()
					.WithMessage("Longitude is required");

			RuleFor(x => x.GeoCoordinates.Latitude)
				.GreaterThan(-90).WithMessage("Latitude must be greater than -90")
				.LessThan(90).WithMessage("Latitude must be less tha 90");

			RuleFor(x => x.GeoCoordinates.Longitude)
				.GreaterThan(-180).WithMessage("Longitude must be greater than -180")
				.LessThan(180).WithMessage("Longitude must be less than 180");

			RuleFor(x => x.TenantId)
				.NotEmpty()
					.WithMessage("TenantId is required");
		}
	}
}