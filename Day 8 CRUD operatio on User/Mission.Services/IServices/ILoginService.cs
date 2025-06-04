using Mission.Entity.Entities;
using Mission.Entity.Model;


namespace Mission.Services.IServices
{
    public interface ILoginService
    {
        ResponseResult LoginUser(LoginUserRequestModel model);

        LoginUserResponseModel UserLogin(LoginUserRequestModel model);

        Task<string> RegisterUser(RegisterUserRequestModel registerUserRequest);

    }
}
