using DAL.Interfaces;
using EverflowTest.Business.Interfaces;

namespace EverflowTest.Business.Services
{
    public class UserService : IUserService
    {
        public IApplicationUserRepository ApplicationUserRepository { get; }

        public UserService(IApplicationUserRepository applicationUserRepository)
        {
            ApplicationUserRepository = applicationUserRepository;
        }

        public async Task<bool> SetUserDetails(Guid userId, string firstName, string lastName)
        {
            var applicationUser = await ApplicationUserRepository
                .Get(userId);

            if (applicationUser != null)
            {
                applicationUser.FirstName = firstName;
                applicationUser.LastName = lastName;

                var result = await ApplicationUserRepository
                    .Update(applicationUser);

                return result.FirstName == firstName
                    && result.LastName == lastName;
            }

            return false;
        }
    }
}