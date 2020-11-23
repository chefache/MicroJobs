namespace MicroJobs.Services.Data
{
    using System.Threading.Tasks;

    using MicroJobs.Data.Common.Repositories;
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Data.Models;

    public class JobsService : IJobsService
    {
        private readonly IRepository<Job> jobsRepository;

        public JobsService(IRepository<Job> jobsRepository)
        {
            this.jobsRepository = jobsRepository;
        }

        public async Task CreateAsync(CreateJobViewModel input)
        {
            var job = new Job
            {
                Name = input.Name,
                JobMainCategory = input.JobMainCategory,
                Town = input.Town,
                Description = input.Description,
                Reward = input.Reward,
                StartDate = input.StartDate,
                EndDate = input.EndDate,
                JobSubCategoryId = input.JobSubCategoryId,
            };

            await this.jobsRepository.AddAsync(job);
            await this.jobsRepository.SaveChangesAsync();
        }
    }
}
