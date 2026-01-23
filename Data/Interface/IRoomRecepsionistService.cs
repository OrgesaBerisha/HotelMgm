using HotelMgm.Data.DTO;

namespace HotelMgm.Data.Interface
{
    public interface IRoomRecepsionistService
    {
        Task<RoomRecepsionistDTO> AddRecepsionist(int userId, RoomRecepsionistDTO dto);
        Task<RoomRecepsionistDTO> GetRecepsionistById(int id);
        Task<IEnumerable<RoomRecepsionistDTO>> GetAllRecepsionists();
        Task<RoomRecepsionistDTO> UpdateRecepsionist(int id, RoomRecepsionistDTO dto);
        Task DeleteRecepsionist(int id);
    }
}
