namespace MicroJobs.Web.ViewModels.Job
{
    using System.Linq;

    using AutoMapper;
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Mapping;

    public class JobInListViewModel : IMapFrom<Job>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SubCategoryName { get; set; }

        public string Description { get; set; }

        public decimal Reward { get; set; }

        public string ImageUrl { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Job, JobInListViewModel>()
                .ForMember(x => x.ImageUrl, opt =>
                opt.MapFrom(j =>
                    j.Images.FirstOrDefault().RemoteImageUrl != null ?
                    j.Images.FirstOrDefault().RemoteImageUrl :
                    "/images/jobs/" + j.Images.FirstOrDefault().Id + "." + j.Images.FirstOrDefault().Extension));
        }
    }
}
