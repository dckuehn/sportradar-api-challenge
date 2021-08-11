using SportradarApiChallenge.Models.Extract;
using SportradarApiChallenge.Models.Transform;
using SportradarApiChallenge.Services._1.Extract;
using SportradarApiChallenge.Services._2.Transform;
using SportradarApiChallenge.Services._3.Load;
using SportradarApiChallenge.Services.Interfaces;
using System.Collections.Generic;

namespace SportradarApiChallenge.Services
{
    public class TeamService : ITeamService
    {
        private NhlApiClient _nhlApiClient;
        private TeamTransformService teamTransformService = new TeamTransformService();
        private TeamFileService teamFileService = new TeamFileService();

        public TeamService(NhlApiClient nhlApiClient)
        {
            _nhlApiClient = nhlApiClient;
        }

        public byte[] SingleTeamSeasonPipeline(int teamId, int year)
        {
            List<Team> teams = _nhlApiClient.GetTeamsById(teamId);

            List<Date> dates = _nhlApiClient.GetScheduleByTeamIdAndSeason(teamId, year);

            TeamPipelineModel tpm = teamTransformService.TransformTeamResult(teams[0], dates);

            return teamFileService.CreateFileStrings(tpm);
        }
    }
}
