namespace MicroJobs.Data.Models
{
    using System.Collections.Generic;

    using MicroJobs.Data.Common.Models;
    using MicroJobs.Data.Models.Enums;

    public class Worker : BaseModel<int>
    {
        public Worker()
        {
            this.Skills = new HashSet<WorkerSkill>();
            this.WorkerImages = new HashSet<WorkerImage>();
        }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public Town Town { get; set; }

        public string AboutMe { get; set; }

        public virtual ICollection<WorkerImage> WorkerImages { get; set; }

        public virtual ICollection<WorkerSkill> Skills { get; set; }
    }
}
