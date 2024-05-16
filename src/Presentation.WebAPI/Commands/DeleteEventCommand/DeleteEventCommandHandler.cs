// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateEventCommand.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// DeleteEventCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace EventService.Presentation.WebAPI.Commands.DeleteEventCommand
{
	using EventService.Domain.AggregateModels.Event.Repository;
	using EventService.Domain.Exceptions;
	using MediatR;

	/// <summary>
	/// <see cref="DeleteEventCommandHandler"/>
	/// </summary>
	/// <seealso cref="IRequestHandler{DeleteEventCommand}" />
	public class DeleteEventCommandHandler : INotificationHandler<DeleteEventCommand>
	{
		/// <summary>
		/// The event repository
		/// </summary>
		private readonly IEventRepository _eventRepository;

		/// <summary>
		/// Initializes a new instance of the <see cref="DeleteEventCommandHandler"/> class.
		/// </summary>
		/// <param name="eventRepository">The event repository.</param>
		public DeleteEventCommandHandler(IEventRepository eventRepository)
		{
			this._eventRepository = eventRepository;
		}

		/// <summary>
		/// Handles the specified command.
		/// </summary>
		/// <param name="command">The command.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <exception cref="EventService.Domain.Exceptions.NotFoundException">The team with id {command.EventId} wasn't found.</exception>
		public async Task Handle(DeleteEventCommand command, CancellationToken cancellationToken)
		{
			var existingEvent = await this._eventRepository.GetAsync(command.EventId, cancellationToken);

			if (existingEvent is null)
			{
				throw new NotFoundException($"The team with id {command.EventId} wasn't found.");
			}

			await this._eventRepository.Remove(existingEvent, cancellationToken);

			await this._eventRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
		}
	}
}