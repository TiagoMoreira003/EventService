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
    ///   <see cref="GetByEventDtoValidator" />
    /// </summary>
    /// <seealso cref="AbstractValidator{GetByEventIdDto}" />
    public class GetByEventDtoValidator : AbstractValidator<GetByEventIdDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetByEventDtoValidator" /> class.
        /// </summary>
        public GetByEventDtoValidator()
        {
            RuleFor(x => x.EventId)
                .NotEmpty()
                    .WithMessage("EventId shouldn't be null.");
        }
    }
}