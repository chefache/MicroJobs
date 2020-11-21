namespace MicroJobs.Data.Models
{
    using System.Collections.Generic;

    using MicroJobs.Data.Common.Models;

    public class JobSubCategory : BaseDeletableModel<int>
    {
        public JobSubCategory()
        {
            this.Jobs = new HashSet<Job>();
        }

        public string Name { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
