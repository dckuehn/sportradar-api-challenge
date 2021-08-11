using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportradarApiChallenge.Services.Interfaces;
using System.Collections.Generic;
using System.Net.Http;

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
        public IActionResult GetTeam(int teamId, int seasonYear)
        {
            byte[] fileBytes = _teamService.SingleTeamSeasonPipeline(teamId, seasonYear);

            return File(fileBytes, "text/csv", $"{teamId}_{seasonYear}.csv");
        }

        [HttpGet]
        [Route("Player")]
        public ActionResult GetPlayer(int playerId, int seasonYear)
        {
            return Ok();
        }
    }
}
