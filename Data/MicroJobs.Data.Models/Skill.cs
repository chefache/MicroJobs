namespace MicroJobs.Data.Models
{
    using System.Collections.Generic;

    using MicroJobs.Data.Common.Models;

    public class Skill : BaseDeletableModel<int>
    {
        public Skill()
        {
            this.Workers = new HashSet<WorkerSkill>();
        }

        public string Name { get; set; }

        public virtual ICollection<WorkerSkill> Workers { get; set; }
    }
}
