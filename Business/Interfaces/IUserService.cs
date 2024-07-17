namespace EverflowTest.Business.Interfaces
{
    public interface IUserService
    {
        Task<bool> SetUserDetails(Guid userId, string firstName, string lastName);
    }
}
