// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Infrastructure.Configuration
{
	using EventService.Domain.AggregateModels.Event.Repository;
	using EventService.Infrastructure.Repository;
	using Microsoft.Extensions.DependencyInjection;

	/// <summary>
	///   <see cref="ServiceCollection" />
	/// </summary>
	public static class ServiceCollection
	{
		/// <summary>
		/// Registers the infrastructure services.
		/// </summary>
		/// <param name="services">The services.</param>
		public static void RegisterInfrastructureServices(this IServiceCollection services)
		{
			services.AddScoped<IEventRepository, EventRepository>();
			services.AddScoped<ILocationRepository, LocationRepository>();
		}
	}
}