namespace MicroJobs.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using MicroJobs.Data.Common.Models;

    public class JobImage : BaseDeletableModel<string>
    {
        public JobImage()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int JobId { get; set; }

        public virtual Job Job { get; set; }

        public string Extension { get; set; }

        public string RemoteImageUrl { get; set; }

        //public string UserId { get; set; }

        //public virtual ApplicationUser User { get; set; }
    }
}
