﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.Configuration
{
	using EventService.Domain.AggregateModels.Event.Builder.EventBuilder;
	using EventService.Domain.AggregateModels.Event.Builder.LocationBuilder;
	using Microsoft.Extensions.DependencyInjection;

	/// <summary>
	///   <see cref="ServiceCollection" />
	/// </summary>
	public static class ServiceCollection
	{
		/// <summary>
		/// Registers the domain services.
		/// </summary>
		/// <param name="services">The services.</param>
		public static void RegisterDomainServices(this IServiceCollection services)
		{
			services.AddScoped<IEventBuilder, EventBuilder>();
			services.AddScoped<ILocationBuilder, LocationBuilder>();
		}
	}
}