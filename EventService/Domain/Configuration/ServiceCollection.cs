// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.Configuration
{
	using Microsoft.Extensions.DependencyInjection;
	using EventService.Domain.AggregateModels.Team.Builder.TeamAcronymBuilder;
	using EventService.Domain.AggregateModels.Team.Builder.TeamBuilder;

	/// <summary>
	/// <see cref="ServiceCollection"/>
	/// </summary>
	public static class ServiceCollection
	{
		/// <summary>
		/// Registers the domain services.
		/// </summary>
		/// <param name="services">The services.</param>
		public static void RegisterDomainServices(this IServiceCollection services)
		{

		}
	}
}