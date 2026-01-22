using HotelMgm.Data.DTO;
using HotelMgm.Models;

namespace HotelMgm.Data.Interface
{
    public interface IAuthService
    {
        Task<User> Register(UserRegistrationDTO request);
        Task<string> Login(UserLoginDTO request);
        Task<UserDTO> ChangePassword(int UserID, ChangePasswordDTO request);
        public Task<string> CreateToken(User user);
        Task<(string accessToken, string refreshToken)> RotateRefreshToken(string oldRefreshToken);
    }
}
