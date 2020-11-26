namespace MicroJobs.Web.ViewModels.Job
{
    using System.Collections.Generic;

    public class JobListViewModel
    {
        public IEnumerable<JobInListViewModel> Jobs { get; set; }

        public int PageNumber { get; set; }
    }
}
