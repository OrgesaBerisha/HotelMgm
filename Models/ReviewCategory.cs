using System.ComponentModel.DataAnnotations;

namespace HotelMgm.Models
{
    public class ReviewCategory
    {
        [Key]
        public int ReviewCategoryID { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
