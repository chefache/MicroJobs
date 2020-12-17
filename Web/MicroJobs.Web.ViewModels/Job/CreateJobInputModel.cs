namespace MicroJobs.Web.ViewModels.Job
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MicroJobs.Data.Models.Enums;
    using Microsoft.AspNetCore.Http;

    public class CreateJobInputModel : BaseJobInputModel
    {
        [Display(Name = "Линк към снимка")]
        public IEnumerable<IFormFile> Images { get; set; }
    }
}
