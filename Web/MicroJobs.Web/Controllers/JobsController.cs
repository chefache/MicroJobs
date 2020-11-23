namespace MicroJobs.Web.Controllers
{
    using MicroJobs.Services.Data;
    using MicroJobs.Web.ViewModels.Job;
    using Microsoft.AspNetCore.Mvc;

    public class JobsController : Controller
    {
        private readonly IJobSubCateroriesService jobSubCateroriesService;

        public JobsController(IJobSubCateroriesService jobSubCateroriesService)
        {
            this.jobSubCateroriesService = jobSubCateroriesService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateJobInputModel();
            viewModel.SubCategoryItems = this.jobSubCateroriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateJobInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                inputModel.SubCategoryItems = this.jobSubCateroriesService.GetAllAsKeyValuePairs();
                return this.View(inputModel);
            }

            // TODO:
            return this.Redirect("/");
        }
    }
}
