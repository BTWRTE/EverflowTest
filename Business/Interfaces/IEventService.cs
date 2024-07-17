using EverflowTest.Models;

namespace EverflowTest.Business.Interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<EventViewModel>> GetAll();
    }
}