namespace MicroJobs.Services.Data
{
    using System.Linq;

    using MicroJobs.Data.Common.Repositories;
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Data.Models;

    public class HomePageCountsService : IHomePageCountsService
    {
        private readonly IRepository<Job> jobsRepository;
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;
        private readonly IDeletableEntityRepository<JobSubCategory> subcategoriesRepository;
        private readonly IRepository<Worker> workersRepository;

        public HomePageCountsService(
            IRepository<Job> jobsRepository,
            IDeletableEntityRepository<ApplicationUser> usersRepository,
            IDeletableEntityRepository<JobSubCategory> subcategoriesRepository,
            IRepository<Worker> workersRepository)
        {
            this.jobsRepository = jobsRepository;
            this.usersRepository = usersRepository;
            this.subcategoriesRepository = subcategoriesRepository;
            this.workersRepository = workersRepository;
        }

        public HomePageCountsServiceViewModel GetCounts()
        {
            var data = new HomePageCountsServiceViewModel
            {
                JobsCount = this.jobsRepository.All().Count(),
                UsersCount = this.usersRepository.All().Count(),
                SubCategoriesCount = this.subcategoriesRepository.All().Count(),
            };

            return data;
        }
    }
}
