namespace MicroJobs.Data.Models
{
    using System.Collections.Generic;

    using MicroJobs.Data.Common.Models;

    public class Portfolio : BaseDeletableModel<int>
    {
        public Portfolio()
        {
            this.Images = new HashSet<Image>();
        }

        public string PortfolioUrl { get; set; }

        public string Description { get; set; }

        public string ThumbneilUrl { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
