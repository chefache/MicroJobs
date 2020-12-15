using System.ComponentModel.DataAnnotations;

namespace MicroJobs.Web.ViewModels.WorkersVotes
{
    public class PostWorkerVoteInputModel
    {
        public int WorkerId { get; set; }

        [Range(1, 5)]
        public byte Value { get; set; }
    }
}
