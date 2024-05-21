// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllEventsDtoValidator.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// GetAllEventsDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Validation.Event
{
    using EventService.Presentation.WebAPI.Query.GetAllActiveEventsQuery;
    using FluentValidation;

    /// <summary>
    /// <see cref="GetAllEventsDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{GetAllActiveEventsCommand}" />
    public class GetAllEventsDtoValidator : AbstractValidator<GetAllActiveEventsQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllEventsDtoValidator"/> class.
        /// </summary>
        public GetAllEventsDtoValidator()
        {

        }
    }
}