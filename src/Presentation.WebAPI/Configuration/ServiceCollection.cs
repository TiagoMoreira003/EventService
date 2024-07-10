// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Configuration
{
	using EventService.Presentation.WebAPI.Commands.UpdateImage;
	using Microsoft.Extensions.DependencyInjection;

	/// <summary>
	/// <see cref="ServiceCollection"/>
	/// </summary>
	public static class ServiceCollection
	{
		/// <summary>
		/// Registers the presentation services.
		/// </summary>
		/// <param name="services">The services.</param>
		public static void RegisterPresentationServices(this IServiceCollection services)
		{
			services.AddScoped<IImage, ImageCommands>();
		}
	}
}