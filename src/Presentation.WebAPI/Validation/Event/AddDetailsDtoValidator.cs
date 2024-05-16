// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddDetailsDtoValidator.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// AddDetailsDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Validation.Event
{
	using EventService.Presentation.WebAPI.Commands.AddDetailsEventCommand;
	using FluentValidation;

	/// <summary>
	/// <see cref="AddDetailsDtoValidator"/>
	/// </summary>
	/// <seealso cref="AbstractValidator{AddDetailsEventCommand}" />
	public class AddDetailsDtoValidator : AbstractValidator<AddDetailsEventCommand>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddDetailsDtoValidator"/> class.
		/// </summary>
		public AddDetailsDtoValidator()
		{
			RuleFor(x => x.Address)
				.NotNull()
					.WithMessage("Address shouldn't be null.");

			RuleFor(x => x.Artists)
				.NotEmpty()
					.WithMessage("Artists shouldn't be null.");

			RuleFor(x => x.Description)
				.MaximumLength(300)
				.WithMessage("Description should be less than 300 characters")
				.NotEmpty()
				.WithMessage("Description shouldn't be null.");

			RuleFor(x => x.EventId)
				.NotEmpty()
					.WithMessage("EventId shouldn't be null.");

			RuleFor(x => x.Location)
				.NotNull()
					.WithMessage("Location shouldn't be null.");

			RuleFor(x => x.Name)
				.MaximumLength(20)
				.WithMessage("Name should be less than 20 characters")
				.NotEmpty()
				.WithMessage("Name shouldn't be null.");

			RuleFor(x => x.MusicType)
				.NotEmpty()
					.WithMessage("MusicType shouldn't be null.");
		}
	}
}