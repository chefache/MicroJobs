namespace MicroJobs.Data.Models
{
    using MicroJobs.Data.Common.Models;

    public class Image : BaseDeletableModel<int>
    {
        public string JobId { get; set; }

        public virtual Job Job { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int PortfolioId { get; set; }

        public virtual Portfolio Portfolio { get; set; }
    }
}
