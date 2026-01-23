using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMgm.Models
{
    public class ReservationStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservationStatusID { get; set; }
        [Required]
        public string ReservationStatusName { get; set; }
        public ICollection<RoomReservation> RoomReservations { get; set; }
    }
}
