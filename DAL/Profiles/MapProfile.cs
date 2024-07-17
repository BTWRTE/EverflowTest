using AutoMapper;
using DAL.Entities;
using DAL.Models;

namespace DAL.Profiles
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ApplicationUser, ApplicationUserModel>()
                .ReverseMap();

            CreateMap<Event, EventModel>()
                .ReverseMap();

            CreateMap<EventUser, EventUserModel>()
                .ReverseMap();

            CreateMap<Location, LocationModel>()
                .ReverseMap();
        }
    }
}