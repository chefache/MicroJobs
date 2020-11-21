namespace MicroJobs.Data.Models
{
    using System.Collections.Generic;

    using MicroJobs.Data.Common.Models;

    public class Town : BaseDeletableModel<int>
    {
        public Town()
        {
            this.JobTowns = new HashSet<JobTown>();
            this.Users = new HashSet<ApplicationUser>();
        }

        public string Name { get; set; }

        public virtual ICollection<JobTown> JobTowns { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
