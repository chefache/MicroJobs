namespace MicroJobs.Data.Models
{
    using MicroJobs.Data.Common.Models;

    public class UserSkill : BaseDeletableModel<int>
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int SkillId { get; set; }

        public virtual Skill Skill { get; set; }
    }
}
