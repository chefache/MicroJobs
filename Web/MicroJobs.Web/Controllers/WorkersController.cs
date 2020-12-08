namespace MicroJobs.Web.Controllers
{
    using System.Threading.Tasks;

    using MicroJobs.Services.Data;
    using MicroJobs.Web.ViewModels.Worker;
    using Microsoft.AspNetCore.Mvc;

    public class WorkersController : Controller
    {
        private readonly IWorkerService workerService;

        public WorkersController(IWorkerService workerService)
        {
            this.workerService = workerService;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateWorkerInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.workerService.CreateAsync(input);

            return this.Redirect("/");
        }
    }
}
