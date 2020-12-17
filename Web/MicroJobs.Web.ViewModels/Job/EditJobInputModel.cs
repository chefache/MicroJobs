namespace MicroJobs.Web.ViewModels.Job
{
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Mapping;

    public class EditJobInputModel : BaseJobInputModel, IMapFrom<Job>
    {
        public int Id { get; set; }
    }
}
