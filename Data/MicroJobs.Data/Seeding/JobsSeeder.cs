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
                JobSubCategoryId = 1,
                Description = "Имам нужда от товарен камион за превоз на багаж от Варна до София",
                Town = Models.Enums.Town.Варна,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 125,
            });

            dbContext.Jobs.Add(new Job
            {
                Name = "Превод на текст от Италиански на Български",
                JobSubCategoryId = 2,
                Description = "Имам нужда от опитен преводач от Италиански език за превод на 50 страници текст формат А4",
                Town = Models.Enums.Town.Пловдив,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(3),
                Reward = 12.50M,
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
