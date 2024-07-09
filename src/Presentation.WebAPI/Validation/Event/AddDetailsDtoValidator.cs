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
	using EventService.Presentation.WebAPI.Dto.Input;
	using EventService.Presentation.WebAPI.Validation.Files;
	using FluentValidation;

	/// <summary>
	/// <see cref="AddDetailsDtoValidator"/>
	/// </summary>
	/// <seealso cref="AbstractValidator{AddDetailsEventDto}" />
	public class AddDetailsDtoValidator : AbstractValidator<AddDetailsEventDto>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AddDetailsDtoValidator"/> class.
		/// </summary>
		public AddDetailsDtoValidator()
		{
			RuleFor(x => x.Address)
				.NotNull()
					.WithMessage("Address shouldn't be null.");

			RuleFor(x => x.Address.Street)
				.NotEmpty()
					.WithMessage("Street shouldn't be null.")
					.MaximumLength(50)
					.WithMessage("Street should be less than 50 characters");

			RuleFor(x => x.Address.State)
				.NotEmpty()
					.WithMessage("State shouldn't be null.")
					.MaximumLength(30)
					.WithMessage("State should be less than 30 characters");

			RuleFor(x => x.Address.PostalCode)
				.NotEmpty()
					.WithMessage("PostalCode shouldn't be null.")
					.MaximumLength(10)
					.WithMessage("PostalCode should be less than 10 characters");

			RuleFor(x => x.Description)
				.MaximumLength(300)
				.WithMessage("Description should be less than 300 characters");

			RuleFor(x => x.Name)
				.MaximumLength(20)
				.WithMessage("Name should be less than 20 characters")
				.NotEmpty()
				.WithMessage("Name shouldn't be null.");

			RuleFor(x => x.Image)
				.SetValidator(new ImageValidator());
		}
	}
}