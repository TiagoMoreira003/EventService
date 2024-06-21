// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationWAdress.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// LocationWAdress
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Dto.Output
{
    /// <summary>
    /// <see cref="LocationWAdress"/>
    /// </summary>
    public class LocationWAdress
    {

        /// <summary>
        /// Gets the latitude.
        /// </summary>
        /// <value>
        /// The latitude.
        /// </value>
        public string Latitude { get; init; }

        /// <summary>
        /// Gets the longitude.
        /// </summary>
        /// <value>
        /// The longitude.
        /// </value>
        public string Longitude { get; init; }

        /// <summary>
        /// Gets the uu identifier.
        /// </summary>
        /// <value>
        /// The uu identifier.
        /// </value>
        public Guid UUId { get; init; }
    }
}