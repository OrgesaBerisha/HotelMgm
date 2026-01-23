using System.ComponentModel.DataAnnotations;

namespace HotelMgm.Data.DTO
{
    public class RoomDTO
    {
        public int RoomID { get; set; }
        [Required]
        public string RoomNumber { get; set; }

        [Required]
        public int RoomTypeID { get; set; }

        [Required]
        public int RoomStatusID { get; set; }
    }
}
