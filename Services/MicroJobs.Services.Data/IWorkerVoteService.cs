namespace MicroJobs.Services.Data
{
    using System.Threading.Tasks;

    public interface IWorkerVoteService
    {
        Task SetVoteAsync(int workerId, string userId, byte value);

        double GetAverageVotes(int workerId);
    }
}
