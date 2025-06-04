using Mission.Entity.Model;
using Mission.Repositories.IRepositories;
using Mission.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.Services
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task<string> DeleteUser(int id)
        {
            return await _userRepository.DeleteUser(id);
        }


        public async Task<UserResponseModel> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }
    }
}
