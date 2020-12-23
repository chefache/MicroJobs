namespace MicroJobs.Web.Controllers
{
    using System.Security.Claims;
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

        [Authorize]
        public IActionResult Edit(int id)
        {
            var inputModel = this.workerService.GetById<EditWorkerInputModel>(id);
            return this.View(inputModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditWorkerInputModel worker)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.workerService.UpdateAsync(id, worker);

            return this.RedirectToAction(nameof(this.SingleWorker), new { id });
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

        public IActionResult AllMy(int id = 1)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value.ToString();

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
                Workers = this.workerService.GetAllMyWorkers<WorkerInListViewModel>(1, userId),
            };

            return this.View(viewModel);
        }

        public IActionResult SingleWorker(int id)
        {
            var worker = this.workerService.GetById<SingleWorkerViewModel>(id);
            return this.View(worker);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await this.workerService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.AllMy));
        }
    }
}
