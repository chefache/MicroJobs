namespace MicroJobs.Web.ViewModels.Worker
{
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Mapping;

    public class EditWorkerInputModel : BaseWorkerInputModel, IMapFrom<Worker>
    {
        public int Id { get; set; }
    }
}
