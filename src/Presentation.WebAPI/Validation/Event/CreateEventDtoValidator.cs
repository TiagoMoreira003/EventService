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
			RuleFor(x => x.EventDate.StartDate)
				.GreaterThan(DateTime.Now);

			RuleFor(x => x.EventDate.EndDate)
				.GreaterThan(DateTime.Now);

			RuleFor(x => x.EventDate.EndDate)
				.GreaterThan(x => x.EventDate.StartDate);

			RuleFor(x => x.GeoCoordinates)
				.NotNull()
					.WithMessage("GeoCoordinates is required");

			RuleFor(x => x.TenantId)
				.NotEmpty()
					.WithMessage("TenantId is required");
		}
	}
}