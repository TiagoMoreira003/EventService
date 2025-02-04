﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UpdateEventCommand.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// UpdateEventCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Commands.UpdateEventCommand
{
    using EventService.Domain.AggregateModels;
    using EventService.Domain.AggregateModels.Event;
    using EventService.Presentation.WebAPI.Dto.Input;
    using MediatR;

    /// <summary>
    ///   <see cref="UpdateEventCommand" />
    /// </summary>
    /// <seealso cref="IRequestHandler{Event}" />
    public class UpdateEventCommand : IRequest<Event>
    {
        /// <summary>
        /// Gets the artists.
        /// </summary>
        /// <value>
        /// The artists.
        /// </value>
        public List<string> Artists { get; init; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; init; }

        /// <summary>
        /// Gets the event date.
        /// </summary>
        /// <value>
        /// The event date.
        /// </value>
        public EventDateDto EventDate { get; init; }

        /// <summary>
        /// Gets the event identifier.
        /// </summary>
        /// <value>
        /// The event identifier.
        /// </value>
        public Guid EventId { get; init; }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public IFormFile Image { get; init; }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public LocationDto Location { get; init; }

        /// <summary>
        /// Gets the type of the music.
        /// </summary>
        /// <value>
        /// The type of the music.
        /// </value>
        public MusicType MusicType { get; init; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; init; }
    }
}