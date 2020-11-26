namespace MicroJobs.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Data;
    using MicroJobs.Services.Data.Models;
    using MicroJobs.Web.ViewModels.Job;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class JobsController : Controller
    {
        private readonly IJobSubCateroriesService jobSubCateroriesService;
        private readonly IJobsService jobsService;
        private readonly UserManager<ApplicationUser> userManager;

        public JobsController(
            IJobSubCateroriesService jobSubCateroriesService,
            IJobsService jobsService,
            UserManager<ApplicationUser> userManager)
        {
            this.jobSubCateroriesService = jobSubCateroriesService;
            this.jobsService = jobsService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreateJobInputModel();
            viewModel.SubCategoryItems = this.jobSubCateroriesService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [Authorize] // Veri important!
        [HttpPost]
        public async Task<IActionResult> Create(CreateJobViewModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                inputModel.SubCategoryItems = this.jobSubCateroriesService.GetAllAsKeyValuePairs();
                return this.View(inputModel);
            }

            // var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value.ToString();
            var user = await this.userManager.GetUserAsync(this.User);
            await this.jobsService.CreateAsync(inputModel, user.Id);

            // TODO: Return user to page with created job
            return this.Redirect("/");
        }

        public IActionResult All(int id)
        {
            var viewModel = new JobListViewModel
            {
                PageNumber = id,
                Jobs = this.jobsService.GetAll<JobInListViewModel>(id, 12),
            };

            return this.View(viewModel);
        }
    }
}
