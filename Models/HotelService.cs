using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMgm.Models
{
    public class HotelService
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string HeroImage { get; set; }

        public required string HeroTitle { get; set; }

        public required string HeroDescription { get; set; }
    }
}
