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
				.GreaterThan(DateTime.Now)
					.WithMessage("The start date should be greater than the current date.")
				.NotNull()
					.WithMessage("StartDate shouldn't be null");

			RuleFor(x => x.EventDate.EndDate)
				.GreaterThan(x => x.EventDate.StartDate)
					.WithMessage("End date should be greater than start date");

			RuleFor(x => x.GeoCoordinates)
				.NotNull()
					.WithMessage("GeoCoordinates is required");

			RuleFor(x => x.GeoCoordinates.Latitude)
				.GreaterThan(-90).WithMessage("Latitude must be greater than -90")
				.LessThan(90).WithMessage("Latitude must be less than 90")
					.NotEmpty()
						.WithMessage("Latitude shouldn't be null.");

			RuleFor(x => x.GeoCoordinates.Longitude)
				.GreaterThan(-180).WithMessage("Longitude must be greater than -180")
				.LessThan(180).WithMessage("Longitude must be less than 180")
					.NotEmpty()
						.WithMessage("Longitude shouldn't be null.");

			RuleFor(x => x.TenantId)
				.NotEmpty()
					.WithMessage("TenantId shouldn't be null.");
		}
	}
}