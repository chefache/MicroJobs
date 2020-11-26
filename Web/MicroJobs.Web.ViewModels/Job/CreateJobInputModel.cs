namespace MicroJobs.Web.ViewModels.Job
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MicroJobs.Data.Models.Enums;

    public class CreateJobInputModel
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Име")]
        public string Name { get; set; }

        // [Required]
        [Display(Name = "Основна категория")]
        public JobMainCategory JobMainCategory { get; set; }

        [Required]
        [Display(Name = "Под-категория")]
        public int JobSubCategoryId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> SubCategoryItems { get; set; }

        [Display(Name = "Град")]
        public Town Town { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Възнаграждение")]
        public decimal Reward { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Начална дата")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Крайна дата")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Линк към снимка")]
        public string JobImageUrl { get; set; }
    }
}
