namespace MicroJobs.Data.Models
{
    using MicroJobs.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        public int JobId { get; set; }

        public virtual Job Job { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public byte Value { get; set; }
    }
}
