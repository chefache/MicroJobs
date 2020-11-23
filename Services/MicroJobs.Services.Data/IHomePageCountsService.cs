namespace MicroJobs.Services.Data
{
    using MicroJobs.Services.Data.Models;

    public interface IHomePageCountsService
    {
        HomePageCountsServiceViewModel GetCounts();
    }
}
