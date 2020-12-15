namespace MicroJobs.Data.Models
{
    using MicroJobs.Data.Common.Models;

    public class JobVote : BaseModel<int>
    {
        public int JobId { get; set; }

        public virtual Job Job { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public byte Value { get; set; }
    }
}
