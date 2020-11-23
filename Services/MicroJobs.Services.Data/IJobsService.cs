namespace MicroJobs.Services.Data
{
    using System.Threading.Tasks;

    using MicroJobs.Services.Data.Models;

    public interface IJobsService
    {
        Task CreateAsync(CreateJobViewModel input);
    }
}
