namespace MicroJobs.Services.Data
{
    using System.Threading.Tasks;

    public interface IVoteService
    {
        Task SetVoteAsync(int jobId, string userId, byte value);

        double GetAverageVotes(int jobId);
    }
}
