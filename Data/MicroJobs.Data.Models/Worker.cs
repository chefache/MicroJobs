using MicroJobs.Data.Common.Models;
using MicroJobs.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroJobs.Data.Models
{
    public class Worker : BaseModel<int>
    {
        public Worker()
        {
            this.Skills = new HashSet<WorkerSkill>();
        }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public Town Town { get; set; }

        public string AboutMe { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<WorkerSkill> Skills { get; set; }
    }
}
