﻿namespace MicroJobs.Data.Models
{
    using System;
    using System.Collections.Generic;

    using MicroJobs.Data.Common.Models;
    using MicroJobs.Data.Models.Enums;

    public class Job : BaseModel<string>
    {
        public Job()
        {
            this.Id = Guid.NewGuid().ToString();
            this.JobTowns = new HashSet<JobTown>();
            this.Images = new HashSet<Image>();
        }

        public string Name { get; set; }

        public JobMainCategory JobMainCategory { get; set; }

        public string Description { get; set; }

        public decimal Reward { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public int JobSubCategoryId { get; set; }

        public virtual JobSubCategory JobSubCategory { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<JobTown> JobTowns { get; set; }
    }
}