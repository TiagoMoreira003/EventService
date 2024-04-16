using EventService.Domain.AggregateModels;

namespace EventService.Presentation.WebAPI.Dto.Output
{
	public class EventDetailsDto
	{
		public EventDateOutputDto EventDate { get; init; }

		public LocationOutputDto Location { get; init; }

		public MusicType MusicType { get; init; }
		public Guid TenantId { get; init; }

		public Guid UUId { get; init; }
		private List<string> Artists { get; init; }
		private string Description { get; init; }
		private string Name { get; init; }
	}
}