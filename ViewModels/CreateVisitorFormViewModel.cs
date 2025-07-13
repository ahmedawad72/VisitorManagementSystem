using System.ComponentModel.DataAnnotations;

namespace VisitorManagementSystem.ViewModels
{
    public class CreateVisitorFormViewModel
    {

        [Required(ErrorMessage = "يجب ادخال اسم الذائر")]
        public string VisitorName { get; set; }

        public string VisitorMilitaryID { get; set; } = string.Empty;

        [Required(ErrorMessage = "يجب إدخال رتبة / درجة الزائر")]
        public string Rank { get; set; }

        [Required(ErrorMessage = "يجب إدخال وظيفة الزائر")]
        public string Job { get; set; }

        [Required(ErrorMessage = "يجب إدخال سبب المقابلة")]
        public string Purpose { get; set; }

        public DateTime RequestTime { get; set; } = DateTime.UtcNow;

        // Add Status for Manager actions (Approved, Waiting, Refused)
        public string Status { get; set; } = "Pending";
    }
}
