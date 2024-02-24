// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILocationBuilder.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// ILocationBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Domain.AggregateModels.Event.Builder.LocationBuilder
{
	/// <summary>
	/// <see cref="ILocationBuilder"/>
	/// </summary>
	public interface ILocationBuilder
	{
		/// <summary>
		/// Builds this instance.
		/// </summary>
		/// <returns></returns>
		Location Build();

		/// <summary>
		/// Creates new team.
		/// </summary>
		/// <param name="datetime">The name.</param>
		/// <param name="artist">The acronym.</param>
		/// <param name="musictype">The name.</param>
		/// <param name="location">The acronym.</param>
		/// <returns></returns>
		ILocationBuilder NewLocation(string latitud, string longitud, Address address);
	}
}