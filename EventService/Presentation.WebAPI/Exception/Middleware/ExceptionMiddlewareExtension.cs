// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExceptionMiddlewareExtension.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ExceptionMiddlewareExtension
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using EventService.Presentation.WebAPI.Exceptions.Middleware;

namespace EventService.Presentation.WebAPI.Exceptions.Middleware
{
	/// <summary>
	/// <see cref="ExceptionMiddlewareExtension"/>
	/// </summary>
	public static class ExceptionMiddlewareExtension
	{
		/// <summary>
		/// Uses the exception middleware.
		/// </summary>
		/// <param name="application">The application.</param>
		public static void UseExceptionMiddleware(this IApplicationBuilder application)
		{
			application.UseMiddleware<ExceptionMiddleware>();
		}
	}
}