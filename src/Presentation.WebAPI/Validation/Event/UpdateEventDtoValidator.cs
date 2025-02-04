﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateEventDtoValidator.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// CreateEventDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Validation.Event
{
    using EventService.Presentation.WebAPI.Dto.Input.UpdateEventDto;
    using EventService.Presentation.WebAPI.Validation.Files;
    using FluentValidation;

    /// <summary>
    /// <see cref="UpdateEventDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{UpdateEventCommand}" />
    public class UpdateEventDtoValidator : AbstractValidator<UpdateEventDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEventDtoValidator"/> class.
        /// </summary>
        public UpdateEventDtoValidator()
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

            RuleFor(x => x.Name)
                .NotEmpty()
                    .WithMessage("The name shouldn't be null")
                        .MaximumLength(20);

            RuleFor(x => x.Description)
                .MaximumLength(300)
                .WithMessage("Description should be less than 300 characters");

            RuleFor(x => x.Location.Address)
                .NotEmpty()
                    .WithMessage("The address shouldn't be null");

            RuleFor(x => x.Location.Address.Street)
                .NotEmpty()
                    .WithMessage("The street shouldn't be null");

            RuleFor(x => x.Location.Address.State)
                .NotEmpty()
                    .WithMessage("The state shouldn't be null");

            RuleFor(x => x.Location.Address.PostalCode)
                .NotEmpty()
                    .WithMessage("The postal code shouldn't be null");

            RuleFor(x => x.Location)
                    .NotNull()
                        .WithMessage("Location shouldn't be null");

            RuleFor(x => x.Location.Latitude)
                .GreaterThan(-90).WithMessage("Latitude must be greater than -90")
                .LessThan(90).WithMessage("Latitude must be less than 90")
                    .NotEmpty()
                    .WithMessage("Latitude cannot be empty!");

            RuleFor(x => x.Location.Longitude)
                .GreaterThan(-180).WithMessage("Longitude must be greater than -180")
                .LessThan(180).WithMessage("Longitude must be less than 180")
                    .NotEmpty()
                    .WithMessage("Longitude cannot be empty!");

            RuleFor(x => x.Image)
                .SetValidator(new ImageValidator());

            RuleFor(x => x.Artists)
                .Must(artists => artists == null || artists.All(artist => !string.IsNullOrWhiteSpace(artist)))
                .WithMessage("Each artist name should be non-empty and non-whitespace.");
        }
    }
}