using Mission.Entity.Entities;
using Mission.Entity.Model;
using Mission.Repositories.Helpers;
using Mission.Repositories.IRepositories;
using Mission.Services.IServices;


namespace Mission.Services.Services
{
    public class LoginService(ILoginRepository loginRepository, JwtService jwtService): ILoginService
    {
        private readonly ILoginRepository _loginRepository = loginRepository;
        private readonly JwtService _jwtService = jwtService;
        ResponseResult result = new ResponseResult();

        public ResponseResult LoginUser(LoginUserRequestModel model)
        {
            var userObj = UserLogin(model);

            if(userObj.Message.ToString() == "Login successfully")
            {
                result.Message = userObj.Message;
                result.Result = ResponseStatus.Success;
                result.Data = _jwtService.GenerateToken(userObj.Id.ToString(), userObj.FirstName, userObj.LastName, userObj.PhoneNumber, userObj.EmailAddress, userObj.UserType, userObj.UserImage);
            }
            else
            {
                result.Message = userObj.Message;
                result.Result = ResponseStatus.Error;
            }
            return result;
        }
        public LoginUserResponseModel UserLogin(LoginUserRequestModel model)
        {
            return _loginRepository.LoginUser(model);
        }

        public async Task<string> RegisterUser(RegisterUserRequestModel registerUserRequest)
        {
            return await _loginRepository.RegisterUser(registerUserRequest);
        }

    }
}
