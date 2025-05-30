using BooksApi.Entities.Entities;
using BooksApi.Entities.Repositories.Interface;
using BooksApi.Services.Services.Interface;

namespace BooksApi.Services.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // To Add User
        public async Task AddUser(Users user)
        {
            await this._userRepository.AddUser(user);
        }

        public Users? Login(string username, string password)
        {
            return this._userRepository.Login(username, password);
        }
    }
}
