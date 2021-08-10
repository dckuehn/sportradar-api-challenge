using SportradarApiChallenge.Models.Extract;
using SportradarApiChallenge.Services._1.Extract;
using SportradarApiChallenge.Services._2.Transform;
using SportradarApiChallenge.Services.Interfaces;
using System.Collections.Generic;

namespace SportradarApiChallenge.Services
{
    public class TeamService : ITeamService
    {
        private NhlApiClient _nhlApiClient;
        private TeamTransformService teamTransformService = new TeamTransformService();

        public TeamService(NhlApiClient nhlApiClient)
        {
            _nhlApiClient = nhlApiClient;
        }

        public void SingleTeamSeasonPipeline(int teamId, int year)
        {
            List<Team> teams = _nhlApiClient.GetTeamsById(teamId);

            List<Date> dates = _nhlApiClient.GetScheduleByTeamIdAndSeason(teamId, year);

            teamTransformService.TransformTeamResult(teams[0], dates);
        }
    }
}
