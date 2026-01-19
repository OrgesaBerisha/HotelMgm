using HotelMgm.Data.DTO;
using HotelMgm.Models;

namespace HotelMgm.Data.Interface
{
    public interface IUserServices
    {
        Task<User> GetUser(int id);
        Task<IEnumerable<UserDTO>> GetAll();

        Task DeleteUser(int id);
        Task<User> UpdateUser(int id, UserDTO request);
        Task<IEnumerable<UserDTO>> GetAllCustomers();
    }
}
