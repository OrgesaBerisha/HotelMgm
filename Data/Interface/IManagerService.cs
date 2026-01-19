using HotelMgm.Data.DTO;

namespace HotelMgm.Data.Interface
{
    public interface IManagerService
    {
        Task<ManagerDTO> CreateManager(ManagerDTO request);
        Task<ManagerDTO> GetManagerById(int id);
        Task<IEnumerable<ManagerDTO>> GetAllManagers();
        Task<ManagerDTO> UpdateManager(int id, ManagerDTO request);
        Task<ManagerDTO> DeleteManager(int id);
        Task<IEnumerable<ManagerTypeDTO>> GetManagerTypes();
    }
}
