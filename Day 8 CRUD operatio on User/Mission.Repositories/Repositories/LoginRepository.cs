using Microsoft.EntityFrameworkCore;
using Mission.Entity.Context;
using Mission.Entity.Entities;
using Mission.Entity.Model;
using Mission.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Repositories.Repositories
{
    public class LoginRepository(MissionDbContext dbContext): ILoginRepository
    {
        private readonly MissionDbContext _dbContext = dbContext;

        public LoginUserResponseModel LoginUser(LoginUserRequestModel model)
        {
            var existingUser = _dbContext.User
                .FirstOrDefault(u => u.EmailAddress.ToLower() == model.EmailAddress.ToLower() && !u.IsDeleted);

            if (existingUser == null)
            {
                return new LoginUserResponseModel() { Message = "Email Address not Found!" };
            }
            if (existingUser.Password != model.Password)
            {
                return new LoginUserResponseModel() { Message = "Incorrect Password!" };
            }
            return new LoginUserResponseModel()
            {
                Id = existingUser.Id,
                FirstName = existingUser.FirstName,
                LastName = existingUser.LastName,
                PhoneNumber = existingUser.PhoneNumber,
                EmailAddress = existingUser.EmailAddress,
                UserType = existingUser.UserType,
                UserImage = existingUser.UserImage,
                Message = "Login Successfully"
            };
        }
        public async Task<string> RegisterUser(RegisterUserRequestModel registerUserRequest)
        {
            var isEmailExist = await _dbContext.User.FirstOrDefaultAsync(u => u.EmailAddress.ToLower() == registerUserRequest.EmailAddress.ToLower());

            if (isEmailExist != null) throw new Exception("User already exist");

            User user = new User()
            {
                FirstName = registerUserRequest.FirstName,
                LastName = registerUserRequest.LastName,
                EmailAddress = registerUserRequest.EmailAddress,
                Password = registerUserRequest.Password,
                PhoneNumber = registerUserRequest.PhoneNumber,
                UserType = registerUserRequest.UserType,
                CreatedDate = DateTime.UtcNow,
            };

            await _dbContext.User.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return "User registered!";
        }
    }

}
