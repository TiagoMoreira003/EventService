
namespace EventService.Presentation.WebAPI.Query.GetAllActiveEventsQuery
{
    using EventService.Domain.AggregateModels.Event;
    using MediatR;
    public class GetAllActiveEventsQuery : IRequest<List<Event>>
    {
    }
}
