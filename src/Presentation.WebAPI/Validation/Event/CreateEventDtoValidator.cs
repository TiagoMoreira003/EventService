namespace EventService.Presentation.WebAPI.Validation.Event
{
	using EventService.Presentation.WebAPI.Dto.Input;
	using FluentValidation;

	public class CreateEventDtoValidator : AbstractValidator<CreateEventDto>
	{
		public CreateEventDtoValidator()
		{
			RuleFor(x => x.EventDate)
				.NotNull()
					.WithMessage("EventDate is required");

			RuleFor(x => x.GeoCoordinates)
				.NotNull()
					.WithMessage("GeoCoordinates is required");

			RuleFor(x => x.TenantId)
				.NotEmpty()
					.WithMessage("TenantId is required");
		}
	}
}