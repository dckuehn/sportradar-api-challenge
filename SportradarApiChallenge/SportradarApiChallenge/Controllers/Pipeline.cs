using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportradarApiChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PipelineController : ControllerBase
    {
        private readonly ILogger<PipelineController> _logger;

        public PipelineController(ILogger<PipelineController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Teams")]
        public ActionResult GetTeam(int teamId, int seasonYear)
        {
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
