using Microsoft.EntityFrameworkCore;
using VisitorManagementSystem.Models;
namespace VisitorManagementSystem.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<HomePageContent> HomePages { get; set; }   
        public DbSet<Visitor> Visitors { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visitor>()
                 .HasData(new Visitor[]
                 {
                    new Visitor{ Id = 1,Rank = "نقيب",VisitorName = "اسلام محمود محمد",Job="رئيس فرع النظم" ,Purpose = "سري" },
                    new Visitor{ Id = 2,Rank = "عقيد",VisitorName = "محمود القناوي",Job="رئيس فرع التجنيد" ,Purpose = "طلبية يوليو" },
                    new Visitor{ Id = 3,Rank = "نقيب",VisitorName = "محمود نزية",Job="رئيس فرع المجمع" ,Purpose = "سري" },
                 });
        }
    }
}
