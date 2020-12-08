namespace MicroJobs.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MicroJobs.Web.ViewModels.Worker;

    public interface IWorkerService
    {
        Task CreateAsync(CreateWorkerInputModel input, string userId);

        IEnumerable<WorkerInListViewModel> GetAll(int page, int itemsPerPage = 12);
    }
}
