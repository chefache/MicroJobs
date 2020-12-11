namespace MicroJobs.Web.Controllers
{
    using System.Threading.Tasks;
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Data;
    using MicroJobs.Web.ViewModels.Worker;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class WorkersController : Controller
    {
        private readonly IWorkerService workerService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment environment;

        public WorkersController(
            IWorkerService workerService,
            UserManager<ApplicationUser> userManager,
            IWebHostEnvironment environment)
        {
            this.workerService = workerService;
            this.userManager = userManager;
            this.environment = environment;
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateWorkerInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var user = await this.userManager.GetUserAsync(this.User);
            await this.workerService.CreateAsync(input, user.Id, $"{this.environment.WebRootPath}/images");

            return this.Redirect("/");
        }

        public IActionResult All(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int itemsPerPage = 12;
            var viewModel = new WorkersListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                WorkersCount = this.workerService.GetCount(),
                Workers = this.workerService.GetAll<WorkerInListViewModel>(id, itemsPerPage),
            };
            return this.View(viewModel);
        }
    }
}
