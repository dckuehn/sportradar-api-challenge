using System;
using System.Collections.Generic;

namespace SportradarApiChallenge.Models.Extract
{
    public class Date
    {
        public DateTime date { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public List<GameTeams> games { get; set; }
    }
}
