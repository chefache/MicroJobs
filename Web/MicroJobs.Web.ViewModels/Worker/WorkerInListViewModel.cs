namespace MicroJobs.Web.ViewModels.Worker
{
    using AutoMapper;
    using MicroJobs.Data.Models;
    using MicroJobs.Data.Models.Enums;
    using MicroJobs.Services.Mapping;
    using System.Linq;

    public class WorkerInListViewModel : IMapFrom<Worker>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Town Town { get; set; }

        public int SkillId { get; set; }

        public string AboutMe { get; set; }

        public string ImageUrl { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Worker, WorkerInListViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                opt.MapFrom(x =>
                        x.Images.FirstOrDefault().RemoteImageUrl != null ?
                        x.Images.FirstOrDefault().RemoteImageUrl :
                        "/images/workers/" + x.Images.FirstOrDefault().Id + '.' + x.Images.FirstOrDefault().Extension));
        }
    }
}
