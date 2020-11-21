namespace MicroJobs.Data.Models
{
    using System;

    using MicroJobs.Data.Common.Models;

    public class Wallet : BaseDeletableModel<string>
    {
        public Wallet()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public decimal Amount { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
