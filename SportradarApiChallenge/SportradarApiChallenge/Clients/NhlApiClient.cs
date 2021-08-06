using SportradarApiChallenge.Models.Extract;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace SportradarApiChallenge.Clients
{
    public class NhlApiClient
    {
        private readonly HttpClient _httpClient;

        public NhlApiClient(HttpClient client)
        {
            _httpClient = client;
        }

        //Teams
        public List<Team> GetTeams()
        {
            var result = _httpClient.GetAsync("/api/v1/teams/30");

            string teamJson = result.Result.Content.ReadAsStringAsync().Result;

            RootTeamResponse teams = JsonSerializer.Deserialize<RootTeamResponse>(teamJson);

            return teams.teams;
        }
    }
}
