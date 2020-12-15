namespace MicroJobs.Web.ViewModels.Worker
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using MicroJobs.Data.Models;
    using MicroJobs.Data.Models.Enums;
    using MicroJobs.Services.Mapping;

    public class SingleWorkerViewModel : IMapFrom<Worker>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public Town Town { get; set; }

        public string AboutMe { get; set; }

        public string ImageUrl { get; set; }

        public double WorkerVoteAverageValue { get; set; }

        public virtual IEnumerable<SkillsViewModel> Skills { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Worker, SingleWorkerViewModel>()
                .ForMember(x => x.WorkerVoteAverageValue, opt =>
                opt.MapFrom(x => x.WorkerVotes.Average(x => x.Value)))
                .ForMember(x => x.ImageUrl, opt =>
                    opt.MapFrom(x =>
                    x.WorkerImages.FirstOrDefault().RemoteImageUrl != null ?
                    x.WorkerImages.FirstOrDefault().RemoteImageUrl :
                    "/images/workers/" + x.WorkerImages.FirstOrDefault().Id + "." + x.WorkerImages.FirstOrDefault().Extension));
        }
    }
}
