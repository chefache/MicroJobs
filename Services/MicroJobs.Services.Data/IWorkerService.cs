namespace MicroJobs.Services.Data
{
    using System.Threading.Tasks;

    using MicroJobs.Web.ViewModels.Worker;

    public interface IWorkerService
    {
        Task CreateAsync(CreateWorkerInputModel input);
    }
}
