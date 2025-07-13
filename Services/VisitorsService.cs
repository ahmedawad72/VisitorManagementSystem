
namespace VisitorManagementSystem.Services
{
    public class VisitorsService : IVisitorsService
    {

        private readonly AppDbContext _context;

        public VisitorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(CreateVisitorFormViewModel model)
        {
            Visitor visitor = new() {
                VisitorName = model.VisitorName,
                Rank = model.Rank,
                Job = model.Job,
                Purpose = model.Purpose,
                VisitorMilitaryID = model.VisitorMilitaryID
            };
            await _context.Visitors.AddAsync(visitor);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Visitor> GetVisitorsList()
        {
          return _context.Visitors.ToList();
        }
    }
}
