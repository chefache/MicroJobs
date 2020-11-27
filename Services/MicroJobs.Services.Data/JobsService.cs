namespace MicroJobs.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
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

        public JobsService(
            IRepository<Job> jobsRepository)
        {
            this.jobsRepository = jobsRepository;
        }

        public async Task CreateAsync(CreateJobInputModel input, string userId, string imagePath)
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
            };

            var allowedExtentions = new[] { "jpg", "png", "gif" };

            Directory.CreateDirectory($"{imagePath}/jobs/");

            foreach (var image in input.Images)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');
                if (!allowedExtentions.Any( x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image format {extension}");
                }

                var dbImage = new Image
                {
                    UserId = userId,
                    Extension = extension,
                };
                job.Images.Add(dbImage);

                var phisicalPath = $"{imagePath}/jobs/{dbImage.Id}.{extension}";
                using Stream fileStream = new FileStream(phisicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

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

        public int GetCount()
        {
            return this.jobsRepository.All().Count();
        }
    }
}
