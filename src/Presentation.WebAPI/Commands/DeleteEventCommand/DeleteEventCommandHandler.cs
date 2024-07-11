// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteEventCommandHandler .cs" company="KROWN">
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
	using EventService.Presentation.WebAPI.Commands.UpdateImage;
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
		/// The image command
		/// </summary>
		private readonly IImage imageCommands;

		/// <summary>
		/// Initializes a new instance of the <see cref="DeleteEventCommandHandler"/> class.
		/// </summary>
		/// <param name="eventRepository">The event repository.</param>
		/// <param name="imageCommand">The image command.</param>
		public DeleteEventCommandHandler(IEventRepository eventRepository, IImage imageCommand)
		{
			this._eventRepository = eventRepository;
			this.imageCommands = imageCommand;
		}

		/// <summary>
		/// Handles the specified command.
		/// </summary>
		/// <param name="command">The command.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <exception cref="NotFoundException">The team with id {command.EventId} wasn't found.</exception>
		public async Task Handle(DeleteEventCommand command, CancellationToken cancellationToken)
		{
			var existingEvent = await this._eventRepository.GetAsync(command.EventId, cancellationToken);

			if (existingEvent.ImageId != Guid.Empty)
			{
				await this.imageCommands.DeleteImageAsync(existingEvent.ImageId);
			}

			if (existingEvent is null)
			{
				throw new NotFoundException($"The team with id {command.EventId} wasn't found.");
			}

			await this._eventRepository.Remove(existingEvent, cancellationToken);

			await this._eventRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
		}
	}
}