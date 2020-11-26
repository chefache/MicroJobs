namespace MicroJobs.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using MicroJobs.Data.Common.Repositories;
    using MicroJobs.Data.Models;

    public class JobSubCateroriesService : IJobSubCateroriesService
    {
        private readonly IDeletableEntityRepository<JobSubCategory> subCategories;

        public JobSubCateroriesService(IDeletableEntityRepository<JobSubCategory> subCategories)
        {
            this.subCategories = subCategories;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.subCategories.AllAsNoTracking()
               .Select(x => new
               {
                   x.Id,
                   x.Name,
               })
               .OrderBy(x => x.Name)
               .ToList()
               .Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
