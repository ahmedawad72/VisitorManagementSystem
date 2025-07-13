
namespace VisitorManagementSystem.Models
{
    public class HomePageContent
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string ImagePath { get; set; }
    }
}
