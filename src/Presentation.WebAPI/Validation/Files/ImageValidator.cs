// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImageValidator.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ImageValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Validation.Files
{
	using FluentValidation;

	/// <summary>
	/// <see cref="ImageValidator"/>
	/// </summary>
	/// <seealso cref="AbstractValidator{IFormFile}" />
	public class ImageValidator : AbstractValidator<IFormFile>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ImageValidator"/> class.
		/// </summary>
		public ImageValidator()
		{
			RuleFor(x => x)
				.Must(file => file == null ||
				file.ContentType.Equals("image/jpeg") ||
				file.ContentType.Equals("image/jpg") ||
				file.ContentType.Equals("image/png"))
				.WithMessage("File must be an image");
		}
	}
}