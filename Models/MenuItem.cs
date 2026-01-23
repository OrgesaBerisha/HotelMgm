using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMgm.Models
{
    public class MenuItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MenuItemID { get; set; }
        [Required]

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }


        public string? image_url { get; set; }

        public Boolean is_available { get; set; }

        public int MenuCategoryID { get; set; }
        public MenuCategory MenuCategory { get; set; }
    }
}
