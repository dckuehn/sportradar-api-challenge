namespace SportradarApiChallenge.Models
{
    public class Team
    {
        int id { get; set; }
        string name { get; set; }
        string link { get; set; }
        Venue venue { get; set; }

        string abbreviation { get; set; }
        string teamName { get; set; }
        string locationName { get; set; }
        string firstYearOfPlay { get; set; }

        Division division { get; set; }
        Conference conference { get; set; }
        
        string shortName { get; set; }
        string officialSiteUrl { get; set; }
        int franchiseId { get; set; }
        bool active { get; set; }
    }
}
