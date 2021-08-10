using SportradarApiChallenge.Models.Extract;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace SportradarApiChallenge.Services._1.Extract
{
    public class NhlApiClient
    {
        private readonly HttpClient _httpClient;

        public NhlApiClient(HttpClient client)
        {
            _httpClient = client;
        }

        //Teams
        public List<Team> GetTeamsById(int teamId)
        {
            var result = _httpClient.GetAsync($"/api/v1/teams?teamId={teamId}");

            string teamJson = result.Result.Content.ReadAsStringAsync().Result;

            RootTeamResponse teams = JsonSerializer.Deserialize<RootTeamResponse>(teamJson);

            return teams.teams;
        }

        public List<Date> GetScheduleByTeamIdAndSeason(int teamId, int year)
        {
            //?startDate={startDate}&endDate={endDate}
            string season = year.ToString() + (year + 1).ToString();

            var result = _httpClient.GetAsync($"/api/v1/schedule?teamId={teamId}&?season={season}");

            string scheduleJson = result.Result.Content.ReadAsStringAsync().Result;

            RootScheduleResponse rootScheduleResponse = JsonSerializer.Deserialize<RootScheduleResponse>(scheduleJson);

            return rootScheduleResponse.dates;
        }
    }
}
