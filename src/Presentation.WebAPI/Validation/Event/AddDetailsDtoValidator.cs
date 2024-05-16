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
					.WithMessage("Address is required");

			RuleFor(x => x.Artists)
				.NotEmpty()
					.WithMessage("Artists is required");

			RuleFor(x => x.Description)
				.NotEmpty()
					.WithMessage("Description is required")
						.MaximumLength(300);

			RuleFor(x => x.EventId)
				.NotEmpty()
					.WithMessage("EventId is required");

			RuleFor(x => x.Location)
				.NotNull()
					.WithMessage("Location is required");

			RuleFor(x => x.Name)
				.NotEmpty()
					.WithMessage("Name is required")
						.MaximumLength(20);

			RuleFor(x => x.MusicType)
				.NotEmpty()
					.WithMessage("MusicType is required");
		}
	}
}