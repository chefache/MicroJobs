namespace MicroJobs.Web.ViewModels.Job
{
    using System;
    using System.Collections.Generic;

    public class JobListViewModel
    {
        public IEnumerable<JobInListViewModel> Jobs { get; set; }

        public int PageNumber { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int PreviousPageNumber => this.PageNumber - 1;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.JobsCount / this.ItemsPerPage);

        public int JobsCount { get; set; }

        public int ItemsPerPage { get; set; }
    }
}
