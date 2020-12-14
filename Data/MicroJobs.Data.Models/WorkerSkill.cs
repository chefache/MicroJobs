namespace MicroJobs.Data.Models
{
    public class WorkerSkill
    {
        public int Id { get; set; }

        public int WorkerId { get; set; }

        public virtual Worker Worker { get; set; }

        public int SkillId { get; set; }

        public virtual Skill Skill { get; set; }

        public string Description { get; set; }
    }
}
