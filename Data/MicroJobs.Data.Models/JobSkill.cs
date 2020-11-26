namespace MicroJobs.Data.Models
{
    using MicroJobs.Data.Common.Models;

    public class JobSkill : BaseDeletableModel<int>
    {
        public int JobId { get; set; }

        public virtual Job Job { get; set; }

        public int SkillId { get; set; }

        public virtual Skill Skill { get; set; }
    }
}
