namespace MicroJobs.Web.Controllers
{
    using System.Threading.Tasks;
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Data;
    using MicroJobs.Web.ViewModels.Worker;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class WorkersController : Controller
    {
        private readonly IWorkerService workerService;
        private readonly UserManager<ApplicationUser> userManager;

        public WorkersController(
            IWorkerService workerService,
            UserManager<ApplicationUser> userManager)
        {
            this.workerService = workerService;
            this.userManager = userManager;
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
            await this.workerService.CreateAsync(input, user.Id);

            return this.Redirect("/");
        }

        public IActionResult All(int id)
        {
            var viewModel = new WorkersListViewModel
            {
                PageNumber = id,
                Workers = this.workerService.GetAll(id, 12),
            };
            return this.View(viewModel);
        }
    }
}
