using DAL.Models;

namespace DAL.Interfaces
{
    public interface IApplicationUserRepository
    {
        Task<ApplicationUserModel> Get(Guid id);
        Task<ApplicationUserModel> Update(ApplicationUserModel model);
    }
}