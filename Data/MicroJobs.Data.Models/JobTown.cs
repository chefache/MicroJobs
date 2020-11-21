namespace MicroJobs.Data.Models
{
    using MicroJobs.Data.Common.Models;

    public class JobTown : BaseDeletableModel<int>
    {
        public string JobId { get; set; }

        public virtual Job Job { get; set; }

        public int TownId { get; set; }

        public virtual Town Town { get; set; }
    }
}
