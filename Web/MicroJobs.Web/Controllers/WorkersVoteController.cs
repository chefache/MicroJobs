namespace MicroJobs.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using MicroJobs.Services.Data;
    using MicroJobs.Web.ViewModels.WorkersVotes;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[Controller]")]
    public class WorkersVoteController : BaseController
    {
        private readonly IWorkerVoteService workerVoteService;

        public WorkersVoteController(IWorkerVoteService workerVoteService)
        {
            this.workerVoteService = workerVoteService;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<PostWorkerVoteResponseModel>> Post(PostWorkerVoteInputModel input)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.workerVoteService.SetVoteAsync(input.WorkerId, userId, input.Value);
            var averageVotes = this.workerVoteService.GetAverageVotes(input.WorkerId);
            return new PostWorkerVoteResponseModel { AverageVote = averageVotes };
        }
    }
}
