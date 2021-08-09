namespace SportradarApiChallenge.Models.Extract
{
    public class GameTeam
    {
        public LeagueRecord leagueRecord { get; set; }
        public int score { get; set; }
        public Team team { get; set; }
    }
}