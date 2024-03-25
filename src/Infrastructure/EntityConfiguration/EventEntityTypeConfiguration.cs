// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventEntityTypeConfiguration.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Infrastructure.EntityConfiguration
{
	using EventService.Domain.AggregateModels.Event;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	/// <summary>
	///   <see cref="EventEntityTypeConfiguration" />
	/// </summary>
	/// <seealso cref="EntityTypeConfiguration{Event}"/>

	internal class EventEntityTypeConfiguration : EntityTypeConfiguration<Event>
	{
		/// <summary>
		/// Gets the name of the table.
		/// </summary>
		/// <value>
		/// The name of the table.
		/// </value>
		protected override string TableName => "Event";

		/// <summary>
		/// Configures the entity.
		/// </summary>
		/// <param name="builder">The builder.</param>
		protected override void ConfigureEntity(EntityTypeBuilder<Event> builder)
		{
			builder.Property(t => t.Artists)
				.HasMaxLength(50)
				.IsRequired();
			builder.Property(t => t.Date)
				.IsRequired();
			builder.Property(t => t.MusicType)
				.IsRequired();
			builder.Property(t => t.Description)
				.HasMaxLength(300)
				.IsRequired();
			builder.HasOne(t => t.Location);
		}
	}
}