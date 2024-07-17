using AutoMapper;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public EventRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<EventModel> Get(Guid id)
        {
            var _event = await context.Event
                .Include(e => e.Location)
                .SingleOrDefaultAsync(e => e.Id == id);

            return mapper
                .Map<EventModel>(_event);
        }

        public async Task<IEnumerable<EventModel>> Get()
        {
            var _events = await context.Event
                .Include(e => e.Location)
                .Where(e => !e.IsDeleted)
                .ToArrayAsync();

            return mapper
                .Map<IEnumerable<EventModel>>(_events);
        }

        public async Task<EventModel> Add(EventModel model)
        {
            var _event = mapper
                .Map<Event>(model);

            await context.Event
                .AddAsync(_event);

            await context
                .SaveChangesAsync();

            return mapper
                .Map<EventModel>(_event);
        }

        public async Task<EventModel> Update(EventModel model)
        {
            var _event = await context.Event
                .Include(e => e.Location)
                .SingleOrDefaultAsync(au => au.Id == model.Id);

            if (_event != null)
            {
                _event.Name = model.Name;
                _event.Description = model.Description;
                _event.StartDate = model.StartDate;
                _event.EndDate = model.EndDate;
                _event.LocationId = model.LocationId;

                if (_event.Location != null && model.Location != null)
                {
                    _event.Location.StreetLine1 = model.Location.StreetLine1;
                    _event.Location.StreetLine2 = model.Location.StreetLine2;
                    _event.Location.StreetLine3 = model.Location.StreetLine3;
                    _event.Location.City = model.Location.City;
                    _event.Location.County = model.Location.County;
                    _event.Location.PostCode = model.Location.PostCode;
                }

                await context
                    .SaveChangesAsync();
            }

            return mapper
                .Map<EventModel>(_event);
        }
    }
}