﻿namespace MicroJobs.Web.Controllers
{
    using System.Diagnostics;

    using MicroJobs.Web.ViewModels;
    using MicroJobs.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                JobsCount = 0,
                UsersCount = 0,
                SubCategoriesCount = 0,
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
