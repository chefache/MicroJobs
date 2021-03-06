﻿namespace MicroJobs.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using MicroJobs.Common;
    using MicroJobs.Data.Models;
    using MicroJobs.Services.Data;
    using MicroJobs.Services.Data.Models;
    using MicroJobs.Web.ViewModels.Job;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class JobsController : Controller
    {
        private readonly IJobSubCateroriesService jobSubCateroriesService;
        private readonly IJobsService jobsService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IWebHostEnvironment environment;

        public JobsController(
            IJobSubCateroriesService jobSubCateroriesService,
            IJobsService jobsService,
            UserManager<ApplicationUser> userManager,
            IWebHostEnvironment environment)
        {
            this.jobSubCateroriesService = jobSubCateroriesService;
            this.jobsService = jobsService;
            this.userManager = userManager;
            this.environment = environment;
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var inputModel = this.jobsService.GetById<EditJobInputModel>(id);
            return this.View(inputModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditJobInputModel job)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.jobsService.UpdateAsync(id, job);

            return this.RedirectToAction(nameof(this.SingleJob), new { id });
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
        public async Task<IActionResult> Create(CreateJobInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                inputModel.SubCategoryItems = this.jobSubCateroriesService.GetAllAsKeyValuePairs();
                return this.View(inputModel);
            }

            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value.ToString();
            var user = await this.userManager.GetUserAsync(this.User);
            await this.jobsService.CreateAsync(inputModel, user.Id, $"{this.environment.WebRootPath}/images");
            inputModel.SubCategoryItems = this.jobSubCateroriesService.GetAllAsKeyValuePairs();
            return this.View(inputModel);

            // TODO: Return user to page with created job
            return this.Redirect("/");
        }

        public IActionResult All(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int itemsPerPage = 12;

            var viewModel = new JobListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                JobsCount = this.jobsService.GetCount(),
                Jobs = this.jobsService.GetAll<JobInListViewModel>(id, itemsPerPage),
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

            var viewModel = new JobListViewModel
            {
                ItemsPerPage = itemsPerPage,
                PageNumber = id,
                JobsCount = this.jobsService.GetCount(),
                Jobs = this.jobsService.GetAllMyJobs<JobInListViewModel>(1, userId),
            };

            return this.View(viewModel);
        }

        public IActionResult SingleJob(int id)
        {
            var job = this.jobsService.GetById<SingleJobViewModel>(id);

            return this.View(job);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await this.jobsService.DeleteAsync(id);
            return this.RedirectToAction(nameof(this.AllMy));
        }
    }
}
