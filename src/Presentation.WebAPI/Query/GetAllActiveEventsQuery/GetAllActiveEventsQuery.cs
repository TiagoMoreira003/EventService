// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllActiveEventsQuery.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// GetAllActiveEventsQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Presentation.WebAPI.Query.GetAllActiveEventsQuery
{
	using EventService.Domain.AggregateModels.Event;
	using MediatR;

	/// <summary>
	/// <see cref="GetAllActiveEventsQuery" />
	/// </summary>
	/// <seealso cref="IRequest{IEnumerable{Event}}" />
	public class GetAllActiveEventsQuery : IRequest<IEnumerable<Event>>
	{
	}
}