namespace MicroJobs.Data.Models
{
    using MicroJobs.Data.Common.Models;

    public class UserJob : BaseDeletableModel<int>
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string JobId { get; set; }

        public virtual Job Job { get; set; }
    }
}
