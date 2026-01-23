using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMgm.Models
{
    public class RestaurantTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int RestaurantTableID { get; set; }
        [Required]

        public int TableNumber { get; set; }

        public int Capacity { get; set; }

        public ICollection<RestaurantReservation> Reservations { get; set; }

    }
}
