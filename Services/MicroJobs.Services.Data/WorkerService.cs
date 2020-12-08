namespace MicroJobs.Services.Data
{
    using System.Collections.Generic;
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

        public async Task CreateAsync(CreateWorkerInputModel input, string userId)
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

            await this.workersRepository.AddAsync(worker);
            await this.workersRepository.SaveChangesAsync();
        }

        public IEnumerable<WorkerInListViewModel> GetAll(int page, int itemsPerPage = 12)
        {
            var workers = this.workersRepository.AllAsNoTracking()
                 .OrderByDescending(x => x.Id)
                 .Skip((page - 1) * itemsPerPage)
                 .Take(itemsPerPage)
                 .To<WorkerInListViewModel>()
                 .ToList();
            return workers;
        }
    }
}
