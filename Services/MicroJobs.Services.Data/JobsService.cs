namespace MicroJobs.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MicroJobs.Data.Common.Repositories;
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Data.Models;
    using MicroJobs.Services.Mapping;
    using MicroJobs.Web.ViewModels.Job;

    public class JobsService : IJobsService
    {
        private readonly IRepository<Job> jobsRepository;

        public JobsService(IRepository<Job> jobsRepository)
        {
            this.jobsRepository = jobsRepository;
        }

        public async Task CreateAsync(CreateJobViewModel input, string userId)
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
                UserId = userId,
                ImageUrl = input.JobImageUrl,
            };

            await this.jobsRepository.AddAsync(job);
            await this.jobsRepository.SaveChangesAsync();
        }

        public IEnumerable<Т> GetAll<Т>(int page, int itemsPerPage = 12)
        {
           var jobs = this.jobsRepository.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .To<Т>()
                .ToList();

           return jobs;
        }
    }
}
