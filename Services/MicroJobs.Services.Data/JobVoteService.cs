﻿namespace MicroJobs.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using MicroJobs.Data.Common.Repositories;
    using MicroJobs.Data.Models;

    public class JobVoteService : IJobVoteService
    {
        private readonly IRepository<JobVote> votesRepository;

        public JobVoteService(IRepository<JobVote> votesRepository)
        {
            this.votesRepository = votesRepository;
        }

        public double GetAverageVotes(int jobId)
        {
            var averageVotes = this.votesRepository.All()
                .Where(x => x.JobId == jobId)
                .Average(x => x.Value);

            return averageVotes;
        }

        public async Task SetVoteAsync(int jobId, string userId, byte value)
        {
            var vote = this.votesRepository
                .All()
                .FirstOrDefault(x => x.JobId == jobId && x.UserId == userId);

            if (vote == null)
            {
                vote = new JobVote
                {
                    JobId = jobId,
                    UserId = userId,
                };

                await this.votesRepository.AddAsync(vote);
            }

            vote.Value = value;
            await this.votesRepository.SaveChangesAsync();
        }
    }
}
