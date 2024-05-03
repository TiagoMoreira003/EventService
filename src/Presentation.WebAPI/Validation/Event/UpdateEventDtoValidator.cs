namespace EventService.Presentation.WebAPI.Validation.Event
{
	using EventService.Presentation.WebAPI.Commands.UpdateEventCommand;
	using FluentValidation;

	public class UpdateEventDtoValidator : AbstractValidator<UpdateEventCommand>
	{
		public UpdateEventDtoValidator()
		{
			RuleFor(x => x.Name)
				.NotEmpty()
					.WithMessage("The name shouldn't be null");

			RuleFor(x => x.Description)
				.NotEmpty()
					.WithMessage("The description shouldn't be null");

			RuleFor(x => x.MusicType)
				.NotEmpty()
					.WithMessage("The name shouldn't be null");

			RuleFor(x => x.Artists)
				.NotEmpty()
				.WithMessage("The artirts shouldn't be null");
		}
	}
}