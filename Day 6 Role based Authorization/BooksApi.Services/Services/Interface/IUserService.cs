using BooksApi.Entities.Entities;

namespace BooksApi.Services.Services.Interface
{
    public interface IUserService
    {
        Task AddUser(Users user);
        Users? Login(string username, string password);
    }
}
