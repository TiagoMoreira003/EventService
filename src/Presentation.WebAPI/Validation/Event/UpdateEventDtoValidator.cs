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
	using EventService.Presentation.WebAPI.Commands.UpdateEventCommand;
	using FluentValidation;

	/// <summary>
	/// <see cref="UpdateEventDtoValidator"/>
	/// </summary>
	/// <seealso cref="AbstractValidator{UpdateEventCommand}" />
	public class UpdateEventDtoValidator : AbstractValidator<UpdateEventCommand>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateEventDtoValidator"/> class.
		/// </summary>
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