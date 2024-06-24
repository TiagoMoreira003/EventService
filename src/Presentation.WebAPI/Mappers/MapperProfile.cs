// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapperProfile.cs" company="KROWN">
//     Copyright (c) KROWN. All rights reserved.
// </copyright>
// <summary>
// MapperProfile
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EventService.Presentation.WebAPI.Mappers
{
    using AutoMapper;
    using EventService.Domain.AggregateModels;
    using EventService.Domain.AggregateModels.Event;
    using EventService.Presentation.WebAPI.Dto.Output;

    /// <summary>
    /// <see cref="MapperProfile"/>
    /// </summary>
    /// <seealso cref="Profile"/>
    public class MapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapperProfile"/> class.
        /// </summary>
        public MapperProfile()
        {
            this.CreateMap<Event, EventPoint>();
            this.CreateMap<Event, EventDto>();
            this.CreateMap<Location, LocationWAdress>();
            this.CreateMap<Location, LocationOutputDto>();
            this.CreateMap<EventDate, EventDateOutputDto>();
            this.CreateMap<Event, EventDetailsDto>();
            this.CreateMap<Address, AddressOutputDto>();



        }
    }
}