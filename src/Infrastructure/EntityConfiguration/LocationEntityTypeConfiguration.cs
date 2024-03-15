// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationEntityTypeConfiguration.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// LocationEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Infrastructure.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using EventService.Domain.AggregateModels.Event;

    internal class LocationEntityTypeConfiguration : EntityTypeConfiguration<Location>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "Location";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Location> builder)
        {
            builder.Property(t => t.Latitude)
                .IsRequired();
            builder.Property(t => t.Longitude)
                .IsRequired();
            //Implementação do address, estava mal feita
            builder.OwnsOne(t => t.Address, a =>
            {
                a.Property(t => t.Street)
                    .IsRequired();
                a.Property(t => t.State)
                    .IsRequired();
                a.Property(t => t.PostalCode)
                    .IsRequired();
            });
        }
    }
}