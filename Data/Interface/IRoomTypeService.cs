using HotelMgm.Data.DTO;

namespace HotelMgm.Data.Interface
{
    public interface IRoomTypeService
    {
        Task<RoomTypeDTO> AddRoomType(RoomTypeDTO request);
        Task<RoomTypeDTO> GetRoomType(int id);
        Task<IEnumerable<RoomTypeDTO>> GetAllRoomTypes();
        Task<RoomTypeDTO> UpdateRoomType(int id, RoomTypeDTO request);
        Task DeleteRoomType(int id);

    }
}
