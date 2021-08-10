using System;

namespace SportradarApiChallenge.Models.Transform
{
    public class TeamPipelineModel
    {

        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string TeamVenueName { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Points { get; set; }
        public double GoalsPerGame { get; set; }
        public string FirstGameDate { get; set; }
        public string FirstGameOpponentTeamName { get; set; }

    }
}
