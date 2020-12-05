namespace MicroJobs.Data.Models
{
    using System;

    using MicroJobs.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int JobId { get; set; }

        public virtual Job Job { get; set; }

        public string Extension { get; set; }

        public string RemoteImageUrl { get; set; }

        public string WorkerId { get; set; }

        public virtual Worker Worker { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
