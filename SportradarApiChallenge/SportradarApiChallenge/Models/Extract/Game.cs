using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportradarApiChallenge.Models.Extract
{
    public class Game
    {
        public int gamePk { get; set; }
        public string link { get; set; }
        public string gametype { get; set; }
        public string season { get; set; }
        public DateTime gameDate { get; set; }
        public Status status { get; set; }
        public GameTeams teams { get; set; }
        public Venue venue { get; set; }
        public Content content { get; set; }

    }
}
