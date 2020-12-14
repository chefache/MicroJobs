namespace MicroJobs.Web.ViewModels.Worker
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MicroJobs.Data.Models.Enums;
    using Microsoft.AspNetCore.Http;

    public class CreateWorkerInputModel
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Име")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [MinLength(3)]
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [Display(Name = "Работен @mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Град")]
        public Town Town { get; set; }

        [Required]
        [Display(Name = "За мен")]
        public string AboutMe { get; set; }

        [Required]
        [Display(Name = "Добави умения")]
        public IEnumerable<WorkerSkillInputModel> Skills { get; set; }

        [Display(Name = "Линк към снимка")]
        public IEnumerable<IFormFile> Images { get; set; }
    }
}
