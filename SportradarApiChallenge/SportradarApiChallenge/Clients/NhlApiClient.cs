using SportradarApiChallenge.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        public void GetTeams()
        {
            var result = _httpClient.GetAsync("/api/v1/teams");

            string teamJson = result.Result.Content.ReadAsStringAsync().Result;

            List<Team> teams = JsonSerializer.Deserialize<List<Team>>(teamJson);
        }
    }
}
