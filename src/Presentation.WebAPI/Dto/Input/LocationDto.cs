namespace EventService.Presentation.WebAPI.Dto.Input
{
	public class LocationDto
	{
		public AddressDto Address { get; init; }
		public double Latitude { get; init; }

		public double Longitude { get; init; }
	}
}