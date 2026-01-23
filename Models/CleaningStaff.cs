using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelMgm.Models
{
    public class CleaningStaff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CleaningStaffID { get; set; }

        [Required]
        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        [RegularExpression("^(Morning|Afternoon|Night)$", ErrorMessage = "Shift must be Morning, Afternoon, or Night.")]
        public string Shift { get; set; }

        public int? AssignedByUserID { get; set; }

        [ForeignKey("AssignedByUserID")]
        public User AssignedBy { get; set; }

        public ICollection<CleaningAssignment> CleaningAssignments { get; set; }

    }
}
