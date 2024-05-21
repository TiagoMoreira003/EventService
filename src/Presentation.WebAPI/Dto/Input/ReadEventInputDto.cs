namespace EventService.Presentation.WebAPI.Dto.Input
{
    /// <summary>
    /// <see cref="ReadEventInputDto" />
    /// </summary>
    public class ReadEventInputDto
    {
        /// <summary>
        /// Gets or sets the event identifier.
        /// </summary>
        /// <value>
        /// The event identifier.
        /// </value>
        public Guid EventId { get; set; }
    }
}
