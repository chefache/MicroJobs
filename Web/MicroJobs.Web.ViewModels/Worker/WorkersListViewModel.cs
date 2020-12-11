namespace MicroJobs.Web.ViewModels.Worker
{
    using System;
    using System.Collections.Generic;

    public class WorkersListViewModel : PagingViewModel
    {
        public IEnumerable<WorkerInListViewModel> Workers { get; set; }

    }
}
