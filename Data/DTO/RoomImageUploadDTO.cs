namespace HotelMgm.Data.DTO
{
    public class RoomImageUploadDTO
    {
        public int RoomTypeID { get; set; }
        public IFormFile Image { get; set; }
        public bool IsPreview { get; set; }
    }
}
