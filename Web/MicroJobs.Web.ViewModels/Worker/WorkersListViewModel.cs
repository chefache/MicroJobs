namespace MicroJobs.Web.ViewModels.Worker
{
    using System.Collections.Generic;

    public class WorkersListViewModel
    {
        public IEnumerable<WorkerInListViewModel> Workers { get; set; }

        public int PageNumber { get; set; }

        public int WorkersCount { get; set; }

        public int ItemsPerPage { get; set; }
    }
}
