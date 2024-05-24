// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventRepository.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Infrastructure.Repository
{
    using EventService.Domain.AggregateModels.Event;
    using EventService.Domain.AggregateModels.Event.Repository;
    using EventService.Domain.AggregateModels.Event.Repository.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="EventRepository" />
    /// </summary>
    /// <seealso cref="IEventRepository" />
    /// <seealso cref="GenericRepository{Event}" />
    internal class EventRepository : GenericRepository<Event>, IEventRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventRepository" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public EventRepository(EventServiceDBContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets the by identifiers asynchronous.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<Event> GetByIdentifiersAsync(GetByIdentifiersModel model, CancellationToken cancellationToken)
        {
            return await this.Entities.SingleOrDefaultAsync(x =>
            x.TenantId == model.TenantId &&
            x.Location.Latitude == model.GeoCoordinates.Latitude &&
            x.Location.Longitude == model.GeoCoordinates.Longitude &&
            x.EventDate.StartDate == model.EventDate.StartDate &&
            x.EventDate.EndDate == model.EventDate.EndDate
            , cancellationToken);
        }

        /// <summary>
        /// Gets the by identifier asynchronous.
        /// </summary>
        /// <param name="eventid">The eventid.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<Event> GetByIdAsync(Guid eventid, CancellationToken cancellationToken)
        {
            return await this.Entities.SingleOrDefaultAsync(t => t.UUId == eventid, cancellationToken);
        }
    }
}