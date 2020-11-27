namespace MicroJobs.Services.Data.Models
{
    using System;
    using System.Collections.Generic;

    using MicroJobs.Data.Models.Enums;
    using Microsoft.AspNetCore.Http;

    public class CreateJobViewModel
    {
        public string Name { get; set; }

        public JobMainCategory JobMainCategory { get; set; }

        public Town Town { get; set; }

        public string Description { get; set; }

        public decimal Reward { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IEnumerable<IFormFile> Images { get; set; }

        public IEnumerable<KeyValuePair<string, string>> SubCategoryItems { get; set; }

        public int JobSubCategoryId { get; set; }
    }
}
