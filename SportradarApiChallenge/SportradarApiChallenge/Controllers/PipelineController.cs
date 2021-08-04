using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportradarApiChallenge.Services.Interfaces;

namespace SportradarApiChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PipelineController : ControllerBase
    {
        private readonly ILogger<PipelineController> _logger;
        private readonly ITeamService _teamService;

        public PipelineController(ILogger<PipelineController> logger, ITeamService teamService)
        {
            _logger = logger;
            _teamService = teamService;
        }

        [HttpGet]
        [Route("Teams")]
        public ActionResult GetTeam(int teamId, int seasonYear)
        {
            _teamService.SingleTeamSeasonPipeline(teamId, seasonYear);

            return Ok();
        }

        [HttpGet]
        [Route("Player")]
        public ActionResult GetPlayer(int playerId, int seasonYear)
        {
            return Ok();
        }
    }
}
