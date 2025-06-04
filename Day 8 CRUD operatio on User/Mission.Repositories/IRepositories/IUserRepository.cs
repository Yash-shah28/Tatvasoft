using Mission.Entity.Model;

namespace Mission.Repositories.IRepositories
{
    public interface IUserRepository
    {
        Task<string> DeleteUser(int id);
        Task<UserResponseModel> GetUserById(int id);
    }
}
