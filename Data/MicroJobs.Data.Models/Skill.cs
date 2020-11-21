namespace MicroJobs.Data.Models
{
    using System.Collections.Generic;

    using MicroJobs.Data.Common.Models;

    public class Skill : BaseDeletableModel<int>
    {
        public Skill()
        {
            this.UserSkills = new HashSet<UserSkill>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<UserSkill> UserSkills { get; set; }
    }
}
