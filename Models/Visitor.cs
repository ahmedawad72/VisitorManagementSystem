using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VisitorManagementSystem.Models
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Visitor Name is Required")]
        public string VisitorName { get; set; }

        public string VisitorMilitaryID { get; set; } = string.Empty;

        [Required(ErrorMessage = "Rank is required")]
        public string Rank { get; set; }

        [Required(ErrorMessage = "Job is required")]
        public string Job { get; set; }

        [Required(ErrorMessage = "Purpose is required")]
        public string Purpose { get; set; }

        public DateTime RequestTime { get; set; } = DateTime.UtcNow;

        // Add Status for Manager actions (Approved, Waiting, Refused)
        public string Status { get; set; } = "Pending";
    }
}
