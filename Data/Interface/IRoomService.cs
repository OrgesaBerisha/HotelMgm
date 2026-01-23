using HotelMgm.Data.DTO;

namespace HotelMgm.Data.Interface
{
    public interface IRoomService
    {
        Task<RoomDTO> AddRoom(RoomDTO request);
        Task<RoomDTO> GetRoom(int id);
        Task<IEnumerable<RoomDTO>> GetAllRooms();
        Task DeleteRoom(int id);
        Task<RoomDTO> UpdateRoom(int id, RoomDTO request);
        Task<RoomDetailsDTO> GetRoomDetails(int id);
        Task BulkCreateRoomsAsync(BulkRoomCreateDTO dto);
    }
}
