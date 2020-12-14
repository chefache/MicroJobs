// ReSharper disable VirtualMemberCallInConstructor
namespace MicroJobs.Data.Models
{
    using System;
    using System.Collections.Generic;

    using MicroJobs.Data.Common.Models;
    using MicroJobs.Data.Models.Enums;
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.Jobs = new HashSet<Job>();
           // this.Images = new HashSet<JobImage>();
            this.Votes = new HashSet<Vote>();
        }

        public int WorkerId { get; set; }

        public virtual Worker Worker { get; set; }

        public string WalletId { get; set; }

        public virtual Wallet Wallet { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }

      //  public virtual ICollection<JobImage> Images { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }
    }
}
