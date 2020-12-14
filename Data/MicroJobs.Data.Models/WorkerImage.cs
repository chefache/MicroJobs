namespace MicroJobs.Data.Models
{
    using System;

    using MicroJobs.Data.Common.Models;

    public class WorkerImage : BaseDeletableModel<string>
    {
        public WorkerImage()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int WorkerId { get; set; }

        public virtual Worker Worker { get; set; }

        public string Extension { get; set; }

        public string RemoteImageUrl { get; set; }

        //public string UserId { get; set; }

        //public virtual ApplicationUser User { get; set; }
    }
}
