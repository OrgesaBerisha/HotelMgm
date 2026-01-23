using HotelMgm.Data.DTO;
using HotelMgm.Models;

namespace HotelMgm.Data.Interface
{
    public interface IRoomImageService
    {
        Task<IEnumerable<RoomImage>> GetImagesByRoomTypeId(int roomId);
        Task<IEnumerable<RoomImage>> GetImagesByRoomTypeIdAndPreviewFlag(int roomTypeId, bool isPreview);

        Task<RoomImage> AddImage(RoomImageDTO dto);
        Task DeleteImage(int imageId);
        Task<RoomImage> GetImageById(int imageId);
    }
}
