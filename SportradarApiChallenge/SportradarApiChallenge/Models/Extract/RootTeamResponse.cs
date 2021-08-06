using System.Collections.Generic;

namespace SportradarApiChallenge.Models.Extract
{
    public class RootTeamResponse
    {
        public string copyright { get; set; }
        public List<Team> teams { get; set; }
    }
}
