// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteEventDtoValidator.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// DeleteEventDtoValidator
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
    public class GetByEventIdDtoValidator : AbstractValidator<GetByEventIdDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetByEventIdDtoValidator"/> class.
        /// </summary>
        public GetByEventIdDtoValidator()
        {
            RuleFor(x => x.EventId)
                .NotEmpty()
                    .WithMessage("EventId shouldn't be null.");
        }
    }
}