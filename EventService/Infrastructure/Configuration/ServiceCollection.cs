﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Infrastructure.Configuration
{
	using Microsoft.Extensions.DependencyInjection;
	using EventService.Domain.AggregateModels.Team.Repository;
	using EventService.Infrastructure.Repository;

	/// <summary>
	/// <see cref="ServiceCollection"/>
	/// </summary>
	public static class ServiceCollection
	{
		/// <summary>
		/// Registers the infrastructure services.
		/// </summary>
		/// <param name="services">The services.</param>
		public static void RegisterInfrastructureServices(this IServiceCollection services)
		{

		}
	}
}