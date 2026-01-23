using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMgm.Models
{
    public class RoomRecepsionist
    {
        [Key]
        public int RoomReceptionistID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

        [Required]
        public string Shift { get; set; }

        [ForeignKey("AssignedByUser")]
        public int AssignedByUserID { get; set; }
        public User AssignedByUser { get; set; }
        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;
    }
}
