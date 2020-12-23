namespace MicroJobs.Web.Controllers
{
    using System.Diagnostics;

    using MicroJobs.Services.Data;
    using MicroJobs.Web.ViewModels;
    using MicroJobs.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IHomePageCountsService homePageCountsService;
        private readonly IWorkerService workerService;

        public HomeController(
            IHomePageCountsService homePageCountsService,
            IWorkerService workerService)
        {
            this.homePageCountsService = homePageCountsService;
            this.workerService = workerService;
        }

        public IActionResult Index()
        {
            var counts = this.homePageCountsService.GetCounts();

            var viewModel = new IndexViewModel
            {
                JobsCount = counts.JobsCount,
                UsersCount = counts.UsersCount,
                SubCategoriesCount = counts.SubCategoriesCount,
                WorkersCount = counts.WorkersCount,
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
