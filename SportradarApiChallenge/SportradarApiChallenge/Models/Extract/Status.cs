namespace SportradarApiChallenge.Models.Extract
{
    public class Status
    {
        public string abstractGameState { get; set; }
        public string codedGameState { get; set; }
        public string detailedGameState { get; set; } 
        public string statusCode { get; set; }
        public bool startTimeTBD { get; set; }
    }
}