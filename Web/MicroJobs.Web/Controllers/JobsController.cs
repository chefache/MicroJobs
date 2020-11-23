namespace MicroJobs.Web.Controllers
{
    using MicroJobs.Services.Data;
    using MicroJobs.Services.Data.Models;
    using MicroJobs.Web.ViewModels.Job;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class JobsController : Controller
    {
        private readonly IJobSubCateroriesService jobSubCateroriesService;
        private readonly IJobsService jobsService;

        public JobsController(
            IJobSubCateroriesService jobSubCateroriesService,
            IJobsService jobsService)
        {
            this.jobSubCateroriesService = jobSubCateroriesService;
            this.jobsService = jobsService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateJobInputModel();
            viewModel.SubCategoryItems = this.jobSubCateroriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateJobViewModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                inputModel.SubCategoryItems = this.jobSubCateroriesService.GetAllAsKeyValuePairs();
                return this.View(inputModel);
            }

            await this.jobsService.CreateAsync(inputModel);

            // TODO:
            return this.Redirect("/");
        }
    }
}
