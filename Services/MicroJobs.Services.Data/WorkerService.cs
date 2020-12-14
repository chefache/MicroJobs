namespace MicroJobs.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using MicroJobs.Data.Common.Repositories;
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Mapping;
    using MicroJobs.Web.ViewModels.Worker;

    public class WorkerService : IWorkerService
    {
        private readonly IRepository<Worker> workersRepository;
        private readonly IDeletableEntityRepository<Skill> skillsRepository;

        public WorkerService(
            IRepository<Worker> workersRepository,
            IDeletableEntityRepository<Skill> skillsRepository)
        {
            this.workersRepository = workersRepository;
            this.skillsRepository = skillsRepository;
        }

        public async Task CreateAsync(CreateWorkerInputModel input, string userId, string imagePath)
        {
            var worker = new Worker
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                PhoneNumber = input.PhoneNumber,
                Town = input.Town,
                AboutMe = input.AboutMe,
                UserId = userId,
            };

            foreach (var skill in input.Skills)
            {
                var currentSkill = this.skillsRepository
                    .All()
                    .FirstOrDefault(x => x.Name == skill.SkillName);

                if (currentSkill == null)
                {
                    currentSkill = new Skill { Name = skill.SkillName };
                }

                worker.Skills.Add(new WorkerSkill
                {
                    Skill = currentSkill,
                    Description = skill.Description,
                });
            }

            var allowedExtentions = new[] { "jpg", "png", "gif" };

            Directory.CreateDirectory($"{imagePath}/workers/");

            foreach (var image in input.Images)
            {
                var extension = Path.GetExtension(image.FileName).TrimStart('.');
                if (!allowedExtentions.Any(x => extension.EndsWith(x)))
                {
                    throw new Exception($"Invalid image format {extension}");
                }

                var dbImage = new WorkerImage
                {
                  //  UserId = userId,
                    Extension = extension,
                };
                worker.WorkerImages.Add(dbImage);

                var phisicalPath = $"{imagePath}/workers/{dbImage.Id}.{extension}";
                using Stream fileStream = new FileStream(phisicalPath, FileMode.Create);
                await image.CopyToAsync(fileStream);
            }

            await this.workersRepository.AddAsync(worker);
            await this.workersRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage = 12)
        {
            var workers = this.workersRepository.AllAsNoTracking()
                 .OrderByDescending(x => x.Id)
                 .Skip((page - 1) * itemsPerPage)
                 .Take(itemsPerPage)
                 .To<T>()
                 .ToList();
            return workers;
        }

        public int GetCount()
        {
            return this.workersRepository.All().Count();
        }
    }
}
