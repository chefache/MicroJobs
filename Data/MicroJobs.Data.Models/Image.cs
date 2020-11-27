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

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int? PortfolioId { get; set; }

        public virtual Portfolio Portfolio { get; set; }
    }
}
