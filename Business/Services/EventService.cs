using DAL.Interfaces;
using DAL.Models;
using EverflowTest.Business.Interfaces;
using EverflowTest.Models;

namespace EverflowTest.Business.Services
{
    public class EventService : IEventService
    {
        public IEventRepository EventRepository { get; }

        public EventService(IEventRepository eventRepository)
        {
            EventRepository = eventRepository;
        }

        public async Task<IEnumerable<EventViewModel>> GetAll()
        {
            return (await EventRepository
                .Get())
                .Select(e => new EventViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                    LocationId = e.LocationId,
                    StreetLine1 = e.Location?.StreetLine1,
                    StreetLine2 = e.Location?.StreetLine2,
                    StreetLine3 = e.Location?.StreetLine3,
                    City = e.Location?.City,
                    County = e.Location?.County,
                    PostCode = e.Location?.PostCode,
                    EventUsers = e.EventUsers
                        .Select(eu => new EventUserViewModel
                        {
                            EventId = e.Id,
                            UserId = eu.UserId,
                            EventName = e.Name,
                            FirstName = eu.User?.FirstName,
                            LastName = eu.User?.LastName
                        })
                        .ToArray()
                })
                .ToArray();
        }
    }
}