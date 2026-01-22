using HotelMgm.Data.DTO;
using HotelMgm.Models;

namespace HotelMgm.Data.Interface
{
    public interface IAdminService
    {
        Task<string> AddUserWithRole(UserRegistrationDTO request);
        Task<IEnumerable<User>> GetUsersByRole(string roleType);
        Task<User> GetUserByIdAndRole(int id, string roleType);
        Task<User> UpdateUserByRole(int id, string roleType, UserDTO request);
        Task<string> DeleteUserByRole(int id, string roleType);
    }
}
