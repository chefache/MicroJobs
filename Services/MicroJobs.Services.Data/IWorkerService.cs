namespace MicroJobs.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MicroJobs.Web.ViewModels.Worker;

    public interface IWorkerService
    {
        Task CreateAsync(CreateWorkerInputModel input, string userId, string imagePath);

        IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12);

        int GetCount();

        T GetById<T>(int id);
    }
}
