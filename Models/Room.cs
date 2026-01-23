using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMgm.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomID { get; set; }
        [Required]
        public string RoomNumber { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int RoomTypeID { get; set; }
        public RoomType RoomType { get; set; }

        public int RoomStatusID { get; set; }
        public RoomStatus RoomStatus { get; set; }

        public ICollection<RoomReservation> Reservations { get; set; }
    }
}
