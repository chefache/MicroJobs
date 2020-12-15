namespace MicroJobs.Data.Models
{
    using MicroJobs.Data.Common.Models;

    public class WorkerVote : BaseModel<int>
    {
        public int WorkerId { get; set; }

        public virtual Worker Worker { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public byte Value { get; set; }
    }
}
