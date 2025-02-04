﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventEntityTypeConfiguration.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// EventEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Infrastructure.EntityConfiguration
{
	using EventService.Domain.AggregateModels;
	using EventService.Domain.AggregateModels.Event;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using System;
	using System.Linq;

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
			builder.OwnsOne(t => t.EventDate, a =>
			{
				a.Property(t => t.StartDate)
				.IsRequired();
				a.Property(t => t.EndDate)
				.IsRequired();
			});

			builder.Property(t => t.MusicType)
				.HasConversion(x =>
					x.ToString(), v =>
						(MusicType)Enum.Parse(typeof(MusicType), v));

			builder.Property(t => t.Description)
				.HasMaxLength(500);

			builder.HasOne(t => t.Location);

			builder.Property(t => t.TenantId)
				.IsRequired();

			builder.Property(t => t.Name)
				.HasMaxLength(50);

			builder.Property(t => t.Artists)
				.HasConversion(
					v => string.Join(',', v),
					v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
					);

			builder.Property(t => t.ImageId);
		}
	}
}