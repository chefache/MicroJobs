namespace MicroJobs.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using MicroJobs.Data.Common.Repositories;
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Data.Models;
    using MicroJobs.Services.Mapping;
    using MicroJobs.Web.ViewModels.Job;
    using Microsoft.AspNetCore.Identity;

    public class JobsService : IJobsService
    {
        private readonly IRepository<Job> jobsRepository;
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;
        private readonly UserManager<ApplicationUser> userManager;

        public JobsService(
            IRepository<Job> jobsRepository,
            IDeletableEntityRepository<ApplicationUser> userRepository,
            UserManager<ApplicationUser> userManager)
        {
            this.jobsRepository = jobsRepository;
            this.userRepository = userRepository;
            this.userManager = userManager;
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
                if (!allowedExtentions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image format {extension}");
                }

                var dbImage = new JobImage
                {
                    // UserId = userId,
                    Extension = extension,
                };
                job.JobImages.Add(dbImage);

                var phisicalPath = $"{imagePath}/jobs/{dbImage.Id}.{extension}";
                using Stream fileStream = new FileStream(phisicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

            await this.jobsRepository.AddAsync(job);
            await this.jobsRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var job = this.jobsRepository.All()
                .FirstOrDefault(x => x.Id == id);
            this.jobsRepository.Delete(job);
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

        public IEnumerable<T> GetAllMyWorks<T>(int page, string userId, int itemsPerPage = 12)
        {

            var jobs = this.jobsRepository.AllAsNoTracking()
               .OrderByDescending(x => x.Id)
               .Where(x => x.User.Id == userId)
               .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
               .To<T>()
               .ToList();

            return jobs;
        }

        public T GetById<T>(int id)
        {
            var singleJob = this.jobsRepository.AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefault();

            return singleJob;
        }

        public int GetCount()
        {
            return this.jobsRepository.All().Count();
        }

        public async Task UpdateAsync(int id, EditJobInputModel input)
        {
            var job = this.jobsRepository
                .All()
                .FirstOrDefault(x => x.Id == id);

            job.Name = input.Name;
            job.Description = input.Description;
            job.StartDate = input.StartDate;
            job.EndDate = input.EndDate;
            job.Town = input.Town;
            job.Reward = input.Reward;

            await this.jobsRepository.SaveChangesAsync();
        }
    }
}
