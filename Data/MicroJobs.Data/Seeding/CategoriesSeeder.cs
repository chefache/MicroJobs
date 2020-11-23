namespace MicroJobs.Data.Seeding
{
    using MicroJobs.Data.Models;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.JobSubCategories.Any())
            {
                return;
            }

            await dbContext.JobSubCategories.AddAsync(new JobSubCategory
            {
                Name = "Почистване",
                CreatedOn = DateTime.UtcNow,
            });

            await dbContext.JobSubCategories.AddAsync(new JobSubCategory
            {
                Name = "Превоз",
                CreatedOn = DateTime.UtcNow,
            });

            await dbContext.JobSubCategories.AddAsync(new JobSubCategory
            {
                Name = "Преводи",
                CreatedOn = DateTime.UtcNow,
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
