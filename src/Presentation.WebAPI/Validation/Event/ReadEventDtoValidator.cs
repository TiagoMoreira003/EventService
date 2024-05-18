// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReadEventDtoValidator.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ReadEventDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Presentation.WebAPI.Validation.Event
{
    using EventService.Presentation.WebAPI.Dto.Input;
    using FluentValidation;

    /// <summary>
    /// <see cref="ReadEventDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{CreateEventDto}" />
    public class ReadEventDtoValidator : AbstractValidator<ReadEventInputDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadEventDtoValidator"/> class.
        /// </summary>
        public ReadEventDtoValidator()
        {
            RuleFor(x => x.EventId)
                .NotEmpty()
                    .WithMessage("EventId shouldn't be null.");
        }
    }
}