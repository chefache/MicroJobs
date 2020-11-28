﻿namespace MicroJobs.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using MicroJobs.Services.Data.Models;
    using MicroJobs.Web.ViewModels.Job;

    public interface IJobsService
    {
        Task CreateAsync(CreateJobInputModel input, string userId, string imagePath);

        IEnumerable<Т> GetAll<Т>(int page, int itemsPerPage = 12);

        int GetCount();
    }
}