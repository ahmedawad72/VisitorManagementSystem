
namespace VisitorManagementSystem.Controllers
{
    public class VisitorsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IVisitorsService _visitorsService;

        public VisitorsController(AppDbContext context, IVisitorsService visitorsService)
        {
            _context = context;
            _visitorsService = visitorsService;
        }

        public IActionResult Index()
        {
            var visitorsList = _visitorsService.GetVisitorsList();
            return View(visitorsList);
        }
    
        // GET: Appointments/Create (Secretary only)
        [HttpGet]
       // [Authorize(Roles = "Secretary")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        // [Authorize(Roles = "Secretary")]
        public IActionResult Create(CreateVisitorFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            // save visitor to database
            _visitorsService.Create(viewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
