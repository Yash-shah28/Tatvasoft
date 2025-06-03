using BooksApi.Entities.Entities;
using BooksApi.Entities.Models;
using BooksApi.Entities.Models.Request;

namespace BooksApi.Services.Services.Interface
{
    public interface IUserService
    {
        Task AddUser(Users user);
        Task<List<UserModel>> GetAllUserAsync(UserRequestModel model);

        Users? Login(string username, string password);
    }
}
