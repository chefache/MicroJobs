namespace MicroJobs.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using MicroJobs.Data.Models;

    public class JobsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Jobs.Any())
            {
                return;
            }

            dbContext.Jobs.Add(new Job
            {
                Name = "Пренасяне на домашен багаж",
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 125,
                JobSubCategoryId = 1,
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански",
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(10),
                Reward = 240,
                JobSubCategoryId = 2,
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
