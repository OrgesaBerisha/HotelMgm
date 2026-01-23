using HotelMgm.Data.DTO;

namespace HotelMgm.Data.Interface
{
    public interface IHostManagementService
    {
        Task<List<HostDTO>> GetAllHostsAsync();

        Task<HostDTO> GetHostByIdAsync(int userId);

        Task<HostDTO> UpdateHostAsync(int id, HostDTO updatedHost);

        Task<string> AssignHostRoleByEmailAsync(string email);

        Task<bool> DeleteHostAsync(int userId);

    }
}
