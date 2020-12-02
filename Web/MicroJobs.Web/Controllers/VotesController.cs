namespace MicroJobs.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using MicroJobs.Services.Data;
    using MicroJobs.Web.ViewModels.Votes;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[Controller]")]
    public class VotesController : BaseController
    {
        private readonly IVoteService voteService;

        public VotesController( IVoteService voteService)
        {
            this.voteService = voteService;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<PostVoteResponseModel>> Post(PostVoteInputModel input)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.voteService.SetVoteAsync(input.JobId, userId, input.Value);
            var averageVotes = this.voteService.GetAverageVotes(input.JobId);
            return new PostVoteResponseModel { AverageVote = averageVotes };
        }
    }
}
