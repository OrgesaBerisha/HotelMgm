using HotelMgm.Data.DTO;
using HotelMgm.Models;

namespace HotelMgm.Data.Interface
{
    public interface IRoomStatusService
    {
        Task<RoomStatus> AddRoomStatus(RoomStatusDTO request);
        Task<RoomStatus> GetRoomStatus(int id);
        Task<IEnumerable<RoomStatus>> GetAllRoomStatus();
        Task DeleteRoomStatus(int id);
        Task<RoomStatus> UpdateRoomStatus(int id, RoomStatusDTO request);
    }
}
