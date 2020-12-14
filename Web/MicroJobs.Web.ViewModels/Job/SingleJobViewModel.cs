namespace MicroJobs.Web.ViewModels.Job
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    using AutoMapper;
    using MicroJobs.Data.Models;
    using MicroJobs.Data.Models.Enums;
    using MicroJobs.Services.Mapping;

    public class SingleJobViewModel : IMapFrom<Job>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SubCategoryName { get; set; }

        public JobMainCategory JobMainCategory { get; set; }

        public string Description { get; set; }

        public decimal Reward { get; set; }

        public double AverageVote { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string ImageUrl { get; set; }

        public string UserEmail { get; set; }

        public Town Town { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Job, SingleJobViewModel>()
                .ForMember(x => x.AverageVote, opt =>
                    opt.MapFrom(x => x.Votes.Count() == 0 ? 0 : x.Votes.Average(v => v.Value)))
                .ForMember(x => x.ImageUrl, opt =>
                opt.MapFrom(j =>
                    j.JobImages.FirstOrDefault().RemoteImageUrl != null ?
                    j.JobImages.FirstOrDefault().RemoteImageUrl :
                    "/images/jobs/" + j.JobImages.FirstOrDefault().Id + "." + j.JobImages.FirstOrDefault().Extension));
        }
    }
}
