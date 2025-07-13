namespace VisitorManagementSystem.Services
{
    public interface IVisitorsService
    {
        IEnumerable<Visitor> GetVisitorsList();
        Task Create(CreateVisitorFormViewModel viewModel);
    }
}
