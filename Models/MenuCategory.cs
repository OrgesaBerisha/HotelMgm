using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMgm.Models
{
    public class MenuCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MenuCategoryID { get; set; }
        [Required]

        public string Name { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
