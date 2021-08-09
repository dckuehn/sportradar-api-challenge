namespace XUnit.SportradarApiChallenge.SampleApiResponses
{
    public class SampleTeamResponses
    {
        public static string MinnesotaWild {
            get
            {
                return
                @"
                {
                  ""copyright"" : ""NHL and the NHL Shield are registered trademarks of the National Hockey League. NHL and NHL team marks are the property of the NHL and its teams. © NHL 2021. All Rights Reserved."",
                  ""teams"" : [ {
                    ""id"" : 30,
                    ""name"" : ""Minnesota Wild"",
                    ""link"" : ""/api/v1/teams/30"",
                    ""venue"" : {
                      ""id"" : 5098,
                      ""name"" : ""Xcel Energy Center"",
                      ""link"" : ""/api/v1/venues/5098"",
                      ""city"" : ""St. Paul"",
                      ""timeZone"" : {
                        ""id"" : ""America/Chicago"",
                        ""offset"" : -5,
                        ""tz"" : ""CDT""
                      }
                    },
                    ""abbreviation"" : ""MIN"",
                    ""teamName"" : ""Wild"",
                    ""locationName"" : ""Minnesota"",
                    ""firstYearOfPlay"" : ""1997"",
                    ""division"" : {
                      ""id"" : 16,
                      ""name"" : ""Central"",
                      ""nameShort"" : ""CEN"",
                      ""link"" : ""/api/v1/divisions/16"",
                      ""abbreviation"" : ""C""
                    },
                    ""conference"" : {
                      ""id"" : 5,
                      ""name"" : ""Western"",
                      ""link"" : ""/api/v1/conferences/5""
                    },
                    ""franchise"" : {
                      ""franchiseId"" : 37,
                      ""teamName"" : ""Wild"",
                      ""link"" : ""/api/v1/franchises/37""
                    },
                    ""shortName"" : ""Minnesota"",
                    ""officialSiteUrl"" : ""http://www.wild.com/"",
                    ""franchiseId"" : 37,
                    ""active"" : true
                  } ]
                }
                ";
            }
        }
    }
}
