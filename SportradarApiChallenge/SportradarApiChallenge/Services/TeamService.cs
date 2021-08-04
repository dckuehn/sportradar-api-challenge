using SportradarApiChallenge.Clients;
using SportradarApiChallenge.Services.Interfaces;

namespace SportradarApiChallenge.Services
{
    public class TeamService : ITeamService
    {
        private NhlApiClient _nhlApiClient;
        public TeamService(NhlApiClient nhlApiClient)
        {
            _nhlApiClient = nhlApiClient;
        }

        public void SingleTeamSeasonPipeline(int teamId, int year)
        {
            _nhlApiClient.GetTeams();
        }
    }
}
