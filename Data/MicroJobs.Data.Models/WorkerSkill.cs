namespace MicroJobs.Data.Models
{
    public class WorkerSkill
    {
        public int Id { get; set; }

        public int WorkerId { get; set; }

        public Worker Worker { get; set; }

        public int SkillId { get; set; }

        public Skill Skill { get; set; }

        public string Description { get; set; }
    }
}
