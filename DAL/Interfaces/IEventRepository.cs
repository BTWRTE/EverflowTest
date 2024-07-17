using DAL.Models;

namespace DAL.Interfaces
{
    public interface IEventRepository
    {
        Task<EventModel> Get(Guid id);
        Task<IEnumerable<EventModel>> Get();
        Task<EventModel> Update(EventModel model);
    }
}