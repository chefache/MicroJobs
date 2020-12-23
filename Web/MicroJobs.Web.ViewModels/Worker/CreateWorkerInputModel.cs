namespace MicroJobs.Web.ViewModels.Worker
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MicroJobs.Data.Models.Enums;
    using Microsoft.AspNetCore.Http;

    public class CreateWorkerInputModel : BaseWorkerInputModel
    {
        [Display(Name = "Линк към снимка")]
        public IEnumerable<IFormFile> Images { get; set; }

        [Required]
        [Display(Name = "Добави умения")]
        public IEnumerable<WorkerSkillInputModel> Skills { get; set; }
    }
}
