namespace MicroJobs.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using MicroJobs.Data.Common.Repositories;
    using MicroJobs.Data.Models;

    public class WorkerVoteService : IWorkerVoteService
    {
        private readonly IRepository<WorkerVote> votesRepository;

        public WorkerVoteService(IRepository<WorkerVote> votesRepository)
        {
            this.votesRepository = votesRepository;
        }

        public double GetAverageVotes(int workerId)
        {
            var averageVotes = this.votesRepository.All()
                 .Where(x => x.WorkerId == workerId)
                 .Average(x => x.Value);

            return averageVotes;
        }

        public async Task SetVoteAsync(int workerId, string userId, byte value)
        {
            var vote = this.votesRepository
                .All()
                .FirstOrDefault(x => x.WorkerId == workerId && x.UserId == userId);

            if (vote == null)
            {
                vote = new WorkerVote
                {
                    WorkerId = workerId,
                    UserId = userId,
                };

                await this.votesRepository.AddAsync(vote);
            }

            vote.Value = value;
            await this.votesRepository.SaveChangesAsync();
        }
    }
}
