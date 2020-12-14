namespace MicroJobs.Web.ViewModels.Worker
{
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Mapping;

    public class SkillsViewModel : IMapFrom<WorkerSkill>
    {
        public string SkillName { get; set; }

        public string Description { get; set; }
    }
}
