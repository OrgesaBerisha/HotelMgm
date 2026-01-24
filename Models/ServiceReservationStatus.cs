using System.ComponentModel.DataAnnotations;

namespace HotelMgm.Models
{
    public class ServiceReservationStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string StatusName { get; set; }
    }
}
