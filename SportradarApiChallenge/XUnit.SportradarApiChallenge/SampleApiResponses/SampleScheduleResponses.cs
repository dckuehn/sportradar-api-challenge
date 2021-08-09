using System;
using System.Collections.Generic;
using System.Text;

namespace XUnit.SportradarApiChallenge.SampleApiResponses
{
    public class SampleScheduleResponses
    {
        public static string MinnesotaWild_20172018 
        {
            get
            {
                return @"
{
  ""copyright"" : ""NHL and the NHL Shield are registered trademarks of the National Hockey League. NHL and NHL team marks are the property of the NHL and its teams. © NHL 2021. All Rights Reserved."",
  ""totalItems"" : 94,
  ""totalEvents"" : 0,
  ""totalGames"" : 94,
  ""totalMatches"" : 0,
  ""metaData"" : {
    ""timeStamp"" : ""20210809_211448""
  },
  ""wait"" : 10,
  ""dates"" : [ {
    ""date"" : ""2017-09-18"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017010008,
      ""link"" : ""/api/v1/game/2017010008/feed/live"",
      ""gameType"" : ""PR"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-09-19T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""6"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""6"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 1,
            ""losses"" : 0,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 0,
            ""losses"" : 0,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 52,
            ""name"" : ""Winnipeg Jets"",
            ""link"" : ""/api/v1/teams/52""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Bell MTS Place"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017010008/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-09-21"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017010039,
      ""link"" : ""/api/v1/game/2017010039/feed/live"",
      ""gameType"" : ""PR"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-09-22T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""6"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""6"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 0,
            ""losses"" : 2,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 52,
            ""name"" : ""Winnipeg Jets"",
            ""link"" : ""/api/v1/teams/52""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 2,
            ""losses"" : 0,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017010039/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-09-23"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017010050,
      ""link"" : ""/api/v1/game/2017010050/feed/live"",
      ""gameType"" : ""PR"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-09-23T22:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""6"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""6"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 1,
            ""losses"" : 2,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 21,
            ""name"" : ""Colorado Avalanche"",
            ""link"" : ""/api/v1/teams/21""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 3,
            ""losses"" : 0,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017010050/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-09-24"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017010061,
      ""link"" : ""/api/v1/game/2017010061/feed/live"",
      ""gameType"" : ""PR"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-09-24T23:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""6"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""6"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 3,
            ""losses"" : 1,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 2,
            ""losses"" : 2,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 21,
            ""name"" : ""Colorado Avalanche"",
            ""link"" : ""/api/v1/teams/21""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Pepsi Center"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017010061/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-09-26"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017010075,
      ""link"" : ""/api/v1/game/2017010075/feed/live"",
      ""gameType"" : ""PR"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-09-27T00:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""6"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""6"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 3,
            ""losses"" : 2,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 3,
            ""losses"" : 2,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 25,
            ""name"" : ""Dallas Stars"",
            ""link"" : ""/api/v1/teams/25""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5019,
        ""name"" : ""American Airlines Center"",
        ""link"" : ""/api/v1/venues/5019""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017010075/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-09-28"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017010090,
      ""link"" : ""/api/v1/game/2017010090/feed/live"",
      ""gameType"" : ""PR"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-09-29T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""6"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""6"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 4,
            ""losses"" : 2,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 3,
            ""losses"" : 4,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 19,
            ""name"" : ""St. Louis Blues"",
            ""link"" : ""/api/v1/teams/19""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5173,
        ""name"" : ""Sprint Center"",
        ""link"" : ""/api/v1/venues/5173""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017010090/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-09-30"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017010101,
      ""link"" : ""/api/v1/game/2017010101/feed/live"",
      ""gameType"" : ""PR"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-10-01T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""6"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""6"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 3,
            ""losses"" : 3,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 25,
            ""name"" : ""Dallas Stars"",
            ""link"" : ""/api/v1/teams/25""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 5,
            ""losses"" : 2,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017010101/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-10-05"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020009,
      ""link"" : ""/api/v1/game/2017020009/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-10-05T23:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 0,
            ""losses"" : 1,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 1,
            ""losses"" : 0,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 17,
            ""name"" : ""Detroit Red Wings"",
            ""link"" : ""/api/v1/teams/17""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5145,
        ""name"" : ""Little Caesars Arena"",
        ""link"" : ""/api/v1/venues/5145""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020009/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-10-07"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020023,
      ""link"" : ""/api/v1/game/2017020023/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-10-07T23:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 0,
            ""losses"" : 1,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 1,
            ""losses"" : 0,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 12,
            ""name"" : ""Carolina Hurricanes"",
            ""link"" : ""/api/v1/teams/12""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5066,
        ""name"" : ""PNC Arena"",
        ""link"" : ""/api/v1/venues/5066""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020023/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-10-12"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020054,
      ""link"" : ""/api/v1/game/2017020054/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-10-13T00:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 1,
            ""losses"" : 1,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 3,
            ""losses"" : 1,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 16,
            ""name"" : ""Chicago Blackhawks"",
            ""link"" : ""/api/v1/teams/16""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5092,
        ""name"" : ""United Center"",
        ""link"" : ""/api/v1/venues/5092""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020054/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-10-14"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020070,
      ""link"" : ""/api/v1/game/2017020070/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-10-15T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 4,
            ""losses"" : 1,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 29,
            ""name"" : ""Columbus Blue Jackets"",
            ""link"" : ""/api/v1/teams/29""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 1,
            ""losses"" : 1,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020070/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-10-20"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020108,
      ""link"" : ""/api/v1/game/2017020108/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-10-21T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 1,
            ""losses"" : 2,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 4,
            ""losses"" : 3,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 52,
            ""name"" : ""Winnipeg Jets"",
            ""link"" : ""/api/v1/teams/52""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Bell MTS Place"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020108/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-10-21"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020120,
      ""link"" : ""/api/v1/game/2017020120/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-10-22T02:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 2,
            ""losses"" : 2,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 4,
            ""losses"" : 4,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 20,
            ""name"" : ""Calgary Flames"",
            ""link"" : ""/api/v1/teams/20""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5075,
        ""name"" : ""Scotiabank Saddledome"",
        ""link"" : ""/api/v1/venues/5075""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020120/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-10-24"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020133,
      ""link"" : ""/api/v1/game/2017020133/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-10-25T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 5,
            ""losses"" : 3,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 23,
            ""name"" : ""Vancouver Canucks"",
            ""link"" : ""/api/v1/teams/23""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 2,
            ""losses"" : 3,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020133/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-10-26"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020146,
      ""link"" : ""/api/v1/game/2017020146/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-10-27T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 5,
            ""losses"" : 4,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 2,
            ""name"" : ""New York Islanders"",
            ""link"" : ""/api/v1/teams/2""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 3,
            ""losses"" : 3,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020146/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-10-28"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020164,
      ""link"" : ""/api/v1/game/2017020164/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-10-29T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 7,
            ""losses"" : 4,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 5,
            ""name"" : ""Pittsburgh Penguins"",
            ""link"" : ""/api/v1/teams/5""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 4,
            ""losses"" : 3,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020164/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-10-31"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020180,
      ""link"" : ""/api/v1/game/2017020180/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-01T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 6,
            ""losses"" : 3,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 52,
            ""name"" : ""Winnipeg Jets"",
            ""link"" : ""/api/v1/teams/52""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 4,
            ""losses"" : 4,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020180/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-02"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020192,
      ""link"" : ""/api/v1/game/2017020192/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-03T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 4,
            ""losses"" : 8,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 8,
            ""name"" : ""Montréal Canadiens"",
            ""link"" : ""/api/v1/teams/8""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 5,
            ""losses"" : 4,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020192/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-04"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020208,
      ""link"" : ""/api/v1/game/2017020208/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-05T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 7,
            ""losses"" : 5,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 16,
            ""name"" : ""Chicago Blackhawks"",
            ""link"" : ""/api/v1/teams/16""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 5,
            ""losses"" : 5,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020208/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-06"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020217,
      ""link"" : ""/api/v1/game/2017020217/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-07T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 5,
            ""losses"" : 6,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 6,
            ""losses"" : 4,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 6,
            ""name"" : ""Boston Bruins"",
            ""link"" : ""/api/v1/teams/6""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5085,
        ""name"" : ""TD Garden"",
        ""link"" : ""/api/v1/venues/5085""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020217/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-08"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020232,
      ""link"" : ""/api/v1/game/2017020232/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-09T00:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 5,
            ""losses"" : 7,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 10,
            ""losses"" : 7,
            ""ot"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 10,
            ""name"" : ""Toronto Maple Leafs"",
            ""link"" : ""/api/v1/teams/10""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5015,
        ""name"" : ""Air Canada Centre"",
        ""link"" : ""/api/v1/venues/5015""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020232/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-09"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020237,
      ""link"" : ""/api/v1/game/2017020237/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-10T00:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 6,
            ""losses"" : 7,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 7,
            ""losses"" : 9,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 8,
            ""name"" : ""Montréal Canadiens"",
            ""link"" : ""/api/v1/teams/8""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Centre Bell"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020237/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-11"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020255,
      ""link"" : ""/api/v1/game/2017020255/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-12T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 7,
            ""losses"" : 7,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 8,
            ""losses"" : 7,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 4,
            ""name"" : ""Philadelphia Flyers"",
            ""link"" : ""/api/v1/teams/4""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5096,
        ""name"" : ""Wells Fargo Center"",
        ""link"" : ""/api/v1/venues/5096""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020255/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-14"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020271,
      ""link"" : ""/api/v1/game/2017020271/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-15T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 8,
            ""losses"" : 8,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 4,
            ""name"" : ""Philadelphia Flyers"",
            ""link"" : ""/api/v1/teams/4""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 8,
            ""losses"" : 7,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020271/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-16"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020283,
      ""link"" : ""/api/v1/game/2017020283/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-17T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 10,
            ""losses"" : 6,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 18,
            ""name"" : ""Nashville Predators"",
            ""link"" : ""/api/v1/teams/18""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 9,
            ""losses"" : 7,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020283/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-18"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020301,
      ""link"" : ""/api/v1/game/2017020301/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-19T00:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 9,
            ""losses"" : 8,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 11,
            ""losses"" : 9,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 15,
            ""name"" : ""Washington Capitals"",
            ""link"" : ""/api/v1/teams/15""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5094,
        ""name"" : ""Capital One Arena"",
        ""link"" : ""/api/v1/venues/5094""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020301/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-20"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020314,
      ""link"" : ""/api/v1/game/2017020314/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-21T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 12,
            ""losses"" : 5,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 1,
            ""name"" : ""New Jersey Devils"",
            ""link"" : ""/api/v1/teams/1""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 9,
            ""losses"" : 8,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020314/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-22"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020319,
      ""link"" : ""/api/v1/game/2017020319/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-23T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 10,
            ""losses"" : 8,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 5,
            ""losses"" : 13,
            ""ot"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 7,
            ""name"" : ""Buffalo Sabres"",
            ""link"" : ""/api/v1/teams/7""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5039,
        ""name"" : ""KeyBank Center"",
        ""link"" : ""/api/v1/venues/5039""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020319/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-24"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020336,
      ""link"" : ""/api/v1/game/2017020336/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-24T21:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 11,
            ""losses"" : 8,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 21,
            ""name"" : ""Colorado Avalanche"",
            ""link"" : ""/api/v1/teams/21""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 11,
            ""losses"" : 8,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020336/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-25"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020354,
      ""link"" : ""/api/v1/game/2017020354/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-26T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 11,
            ""losses"" : 9,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 17,
            ""losses"" : 6,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 19,
            ""name"" : ""St. Louis Blues"",
            ""link"" : ""/api/v1/teams/19""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Scottrade Center"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020354/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-27"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020365,
      ""link"" : ""/api/v1/game/2017020365/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-11-28T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 11,
            ""losses"" : 10,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 15,
            ""losses"" : 6,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 7,
          ""team"" : {
            ""id"" : 52,
            ""name"" : ""Winnipeg Jets"",
            ""link"" : ""/api/v1/teams/52""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Bell MTS Place"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020365/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-11-30"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020384,
      ""link"" : ""/api/v1/game/2017020384/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-01T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 15,
            ""losses"" : 8,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 54,
            ""name"" : ""Vegas Golden Knights"",
            ""link"" : ""/api/v1/teams/54""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 12,
            ""losses"" : 10,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020384/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-02"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020397,
      ""link"" : ""/api/v1/game/2017020397/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-02T23:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 17,
            ""losses"" : 8,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 19,
            ""name"" : ""St. Louis Blues"",
            ""link"" : ""/api/v1/teams/19""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 13,
            ""losses"" : 10,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020397/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-05"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020425,
      ""link"" : ""/api/v1/game/2017020425/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-06T03:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 13,
            ""losses"" : 11,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 18,
            ""losses"" : 8,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 26,
            ""name"" : ""Los Angeles Kings"",
            ""link"" : ""/api/v1/teams/26""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5081,
        ""name"" : ""STAPLES Center"",
        ""link"" : ""/api/v1/venues/5081""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020425/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-08"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020443,
      ""link"" : ""/api/v1/game/2017020443/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-09T03:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 14,
            ""losses"" : 11,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 12,
            ""losses"" : 11,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 24,
            ""name"" : ""Anaheim Ducks"",
            ""link"" : ""/api/v1/teams/24""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5046,
        ""name"" : ""Honda Center"",
        ""link"" : ""/api/v1/venues/5046""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020443/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-10"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020459,
      ""link"" : ""/api/v1/game/2017020459/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-11T02:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 15,
            ""losses"" : 11,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 16,
            ""losses"" : 10,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 28,
            ""name"" : ""San Jose Sharks"",
            ""link"" : ""/api/v1/teams/28""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""SAP Center at San Jose"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020459/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-12"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020472,
      ""link"" : ""/api/v1/game/2017020472/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-13T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 16,
            ""losses"" : 12,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 20,
            ""name"" : ""Calgary Flames"",
            ""link"" : ""/api/v1/teams/20""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 16,
            ""losses"" : 11,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020472/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-14"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020484,
      ""link"" : ""/api/v1/game/2017020484/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-15T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 20,
            ""losses"" : 12,
            ""ot"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 10,
            ""name"" : ""Toronto Maple Leafs"",
            ""link"" : ""/api/v1/teams/10""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 17,
            ""losses"" : 11,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020484/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-16"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020496,
      ""link"" : ""/api/v1/game/2017020496/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-16T19:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 14,
            ""losses"" : 17,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 22,
            ""name"" : ""Edmonton Oilers"",
            ""link"" : ""/api/v1/teams/22""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 17,
            ""losses"" : 12,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020496/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-17"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020508,
      ""link"" : ""/api/v1/game/2017020508/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-18T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 17,
            ""losses"" : 13,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 17,
            ""losses"" : 11,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 16,
            ""name"" : ""Chicago Blackhawks"",
            ""link"" : ""/api/v1/teams/16""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5092,
        ""name"" : ""United Center"",
        ""link"" : ""/api/v1/venues/5092""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020508/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-19"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020520,
      ""link"" : ""/api/v1/game/2017020520/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-20T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 18,
            ""losses"" : 13,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 11,
            ""losses"" : 14,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 9,
            ""name"" : ""Ottawa Senators"",
            ""link"" : ""/api/v1/teams/9""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5031,
        ""name"" : ""Canadian Tire Centre"",
        ""link"" : ""/api/v1/venues/5031""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020520/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-22"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020540,
      ""link"" : ""/api/v1/game/2017020540/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-23T00:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 18,
            ""losses"" : 14,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 14,
            ""losses"" : 16,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 13,
            ""name"" : ""Florida Panthers"",
            ""link"" : ""/api/v1/teams/13""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5027,
        ""name"" : ""BB&T Center"",
        ""link"" : ""/api/v1/venues/5027""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020540/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-23"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020545,
      ""link"" : ""/api/v1/game/2017020545/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-24T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 18,
            ""losses"" : 15,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 26,
            ""losses"" : 7,
            ""ot"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 14,
            ""name"" : ""Tampa Bay Lightning"",
            ""link"" : ""/api/v1/teams/14""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5017,
        ""name"" : ""Amalie Arena"",
        ""link"" : ""/api/v1/venues/5017""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020545/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-27"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020565,
      ""link"" : ""/api/v1/game/2017020565/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-28T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 20,
            ""losses"" : 15,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 25,
            ""name"" : ""Dallas Stars"",
            ""link"" : ""/api/v1/teams/25""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 19,
            ""losses"" : 15,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020565/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-29"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020581,
      ""link"" : ""/api/v1/game/2017020581/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-30T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 22,
            ""losses"" : 10,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 18,
            ""name"" : ""Nashville Predators"",
            ""link"" : ""/api/v1/teams/18""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 20,
            ""losses"" : 15,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020581/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2017-12-30"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020591,
      ""link"" : ""/api/v1/game/2017020591/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2017-12-31T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 20,
            ""losses"" : 16,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 23,
            ""losses"" : 10,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 18,
            ""name"" : ""Nashville Predators"",
            ""link"" : ""/api/v1/teams/18""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5030,
        ""name"" : ""Bridgestone Arena"",
        ""link"" : ""/api/v1/venues/5030""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020591/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-01-02"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020608,
      ""link"" : ""/api/v1/game/2017020608/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-01-03T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 17,
            ""losses"" : 17,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 13,
            ""name"" : ""Florida Panthers"",
            ""link"" : ""/api/v1/teams/13""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 21,
            ""losses"" : 16,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020608/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-01-04"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020622,
      ""link"" : ""/api/v1/game/2017020622/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-01-05T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 10,
            ""losses"" : 21,
            ""ot"" : 9,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 7,
            ""name"" : ""Buffalo Sabres"",
            ""link"" : ""/api/v1/teams/7""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 22,
            ""losses"" : 16,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020622/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-01-06"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020635,
      ""link"" : ""/api/v1/game/2017020635/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-01-07T02:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 22,
            ""losses"" : 17,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 22,
            ""losses"" : 16,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 7,
          ""team"" : {
            ""id"" : 21,
            ""name"" : ""Colorado Avalanche"",
            ""link"" : ""/api/v1/teams/21""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Pepsi Center"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020635/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-01-09"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020659,
      ""link"" : ""/api/v1/game/2017020659/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-01-10T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 22,
            ""losses"" : 16,
            ""ot"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 20,
            ""name"" : ""Calgary Flames"",
            ""link"" : ""/api/v1/teams/20""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 22,
            ""losses"" : 17,
            ""ot"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020659/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-01-10"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020661,
      ""link"" : ""/api/v1/game/2017020661/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-01-11T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 23,
            ""losses"" : 17,
            ""ot"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 21,
            ""losses"" : 16,
            ""ot"" : 6,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 16,
            ""name"" : ""Chicago Blackhawks"",
            ""link"" : ""/api/v1/teams/16""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5092,
        ""name"" : ""United Center"",
        ""link"" : ""/api/v1/venues/5092""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020661/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-01-13"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020674,
      ""link"" : ""/api/v1/game/2017020674/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-01-14T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 26,
            ""losses"" : 13,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 52,
            ""name"" : ""Winnipeg Jets"",
            ""link"" : ""/api/v1/teams/52""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 24,
            ""losses"" : 17,
            ""ot"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020674/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-01-14"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020682,
      ""link"" : ""/api/v1/game/2017020682/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-01-15T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 18,
            ""losses"" : 21,
            ""ot"" : 6,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 23,
            ""name"" : ""Vancouver Canucks"",
            ""link"" : ""/api/v1/teams/23""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 24,
            ""losses"" : 17,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020682/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-01-20"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020719,
      ""link"" : ""/api/v1/game/2017020719/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-01-21T02:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 31,
            ""losses"" : 12,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 14,
            ""name"" : ""Tampa Bay Lightning"",
            ""link"" : ""/api/v1/teams/14""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 25,
            ""losses"" : 17,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020719/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-01-22"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020728,
      ""link"" : ""/api/v1/game/2017020728/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-01-23T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 15,
            ""losses"" : 21,
            ""ot"" : 9,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 9,
            ""name"" : ""Ottawa Senators"",
            ""link"" : ""/api/v1/teams/9""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 26,
            ""losses"" : 17,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020728/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-01-25"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020748,
      ""link"" : ""/api/v1/game/2017020748/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-01-26T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 26,
            ""losses"" : 18,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 27,
            ""losses"" : 21,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 5,
            ""name"" : ""Pittsburgh Penguins"",
            ""link"" : ""/api/v1/teams/5""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5034,
        ""name"" : ""PPG Paints Arena"",
        ""link"" : ""/api/v1/venues/5034""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020748/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-01-30"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020766,
      ""link"" : ""/api/v1/game/2017020766/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-01-31T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 27,
            ""losses"" : 18,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 27,
            ""losses"" : 19,
            ""ot"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 29,
            ""name"" : ""Columbus Blue Jackets"",
            ""link"" : ""/api/v1/teams/29""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5059,
        ""name"" : ""Nationwide Arena"",
        ""link"" : ""/api/v1/venues/5059""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020766/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-02"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020791,
      ""link"" : ""/api/v1/game/2017020791/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-03T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 34,
            ""losses"" : 13,
            ""ot"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 54,
            ""name"" : ""Vegas Golden Knights"",
            ""link"" : ""/api/v1/teams/54""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 28,
            ""losses"" : 18,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020791/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-03"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020801,
      ""link"" : ""/api/v1/game/2017020801/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-04T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 28,
            ""losses"" : 19,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 30,
            ""losses"" : 19,
            ""ot"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 25,
            ""name"" : ""Dallas Stars"",
            ""link"" : ""/api/v1/teams/25""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5019,
        ""name"" : ""American Airlines Center"",
        ""link"" : ""/api/v1/venues/5019""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020801/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-06"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020819,
      ""link"" : ""/api/v1/game/2017020819/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-07T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 29,
            ""losses"" : 19,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 32,
            ""losses"" : 20,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 19,
            ""name"" : ""St. Louis Blues"",
            ""link"" : ""/api/v1/teams/19""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Scottrade Center"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020819/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-08"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020832,
      ""link"" : ""/api/v1/game/2017020832/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-09T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 13,
            ""losses"" : 32,
            ""ot"" : 9,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 53,
            ""name"" : ""Arizona Coyotes"",
            ""link"" : ""/api/v1/teams/53""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 29,
            ""losses"" : 19,
            ""ot"" : 6,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020832/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-10"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020849,
      ""link"" : ""/api/v1/game/2017020849/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-11T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 24,
            ""losses"" : 23,
            ""ot"" : 8,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 16,
            ""name"" : ""Chicago Blackhawks"",
            ""link"" : ""/api/v1/teams/16""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 30,
            ""losses"" : 19,
            ""ot"" : 6,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020849/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-13"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020872,
      ""link"" : ""/api/v1/game/2017020872/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-14T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 27,
            ""losses"" : 25,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 3,
            ""name"" : ""New York Rangers"",
            ""link"" : ""/api/v1/teams/3""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 31,
            ""losses"" : 19,
            ""ot"" : 6,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020872/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-15"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020885,
      ""link"" : ""/api/v1/game/2017020885/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-16T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 33,
            ""losses"" : 17,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 15,
            ""name"" : ""Washington Capitals"",
            ""link"" : ""/api/v1/teams/15""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 31,
            ""losses"" : 20,
            ""ot"" : 6,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020885/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-17"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020896,
      ""link"" : ""/api/v1/game/2017020896/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-17T19:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 29,
            ""losses"" : 20,
            ""ot"" : 11,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 24,
            ""name"" : ""Anaheim Ducks"",
            ""link"" : ""/api/v1/teams/24""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 31,
            ""losses"" : 20,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020896/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-19"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020912,
      ""link"" : ""/api/v1/game/2017020912/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-19T18:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 32,
            ""losses"" : 20,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 29,
            ""losses"" : 26,
            ""ot"" : 6,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 2,
            ""name"" : ""New York Islanders"",
            ""link"" : ""/api/v1/teams/2""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5026,
        ""name"" : ""Barclays Center"",
        ""link"" : ""/api/v1/venues/5026""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020912/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-22"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020931,
      ""link"" : ""/api/v1/game/2017020931/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-23T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 33,
            ""losses"" : 20,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 31,
            ""losses"" : 22,
            ""ot"" : 8,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 1,
            ""name"" : ""New Jersey Devils"",
            ""link"" : ""/api/v1/teams/1""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Prudential Center"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020931/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-23"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020941,
      ""link"" : ""/api/v1/game/2017020941/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-24T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 34,
            ""losses"" : 20,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 27,
            ""losses"" : 30,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 3,
            ""name"" : ""New York Rangers"",
            ""link"" : ""/api/v1/teams/3""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5054,
        ""name"" : ""Madison Square Garden"",
        ""link"" : ""/api/v1/venues/5054""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020941/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-25"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020961,
      ""link"" : ""/api/v1/game/2017020961/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-26T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 33,
            ""losses"" : 21,
            ""ot"" : 9,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 28,
            ""name"" : ""San Jose Sharks"",
            ""link"" : ""/api/v1/teams/28""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 35,
            ""losses"" : 20,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020961/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-02-27"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020973,
      ""link"" : ""/api/v1/game/2017020973/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-02-28T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 34,
            ""losses"" : 26,
            ""ot"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 19,
            ""name"" : ""St. Louis Blues"",
            ""link"" : ""/api/v1/teams/19""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 36,
            ""losses"" : 20,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 8,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020973/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-01"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020988,
      ""link"" : ""/api/v1/game/2017020988/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-02T02:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 36,
            ""losses"" : 21,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 19,
            ""losses"" : 34,
            ""ot"" : 10,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 53,
            ""name"" : ""Arizona Coyotes"",
            ""link"" : ""/api/v1/teams/53""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5043,
        ""name"" : ""Gila River Arena"",
        ""link"" : ""/api/v1/venues/5043""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020988/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-02"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017020995,
      ""link"" : ""/api/v1/game/2017020995/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-03T02:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 36,
            ""losses"" : 22,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 35,
            ""losses"" : 24,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 7,
          ""team"" : {
            ""id"" : 21,
            ""name"" : ""Colorado Avalanche"",
            ""link"" : ""/api/v1/teams/21""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Pepsi Center"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017020995/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-04"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021013,
      ""link"" : ""/api/v1/game/2017021013/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-05T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 26,
            ""losses"" : 29,
            ""ot"" : 10,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 17,
            ""name"" : ""Detroit Red Wings"",
            ""link"" : ""/api/v1/teams/17""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 37,
            ""losses"" : 22,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021013/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-06"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021026,
      ""link"" : ""/api/v1/game/2017021026/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-07T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 29,
            ""losses"" : 27,
            ""ot"" : 11,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 12,
            ""name"" : ""Carolina Hurricanes"",
            ""link"" : ""/api/v1/teams/12""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 38,
            ""losses"" : 22,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021026/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-09"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021047,
      ""link"" : ""/api/v1/game/2017021047/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-10T03:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 39,
            ""losses"" : 22,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 25,
            ""losses"" : 34,
            ""ot"" : 9,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 23,
            ""name"" : ""Vancouver Canucks"",
            ""link"" : ""/api/v1/teams/23""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5073,
        ""name"" : ""Rogers Arena"",
        ""link"" : ""/api/v1/venues/5073""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021047/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-10"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021058,
      ""link"" : ""/api/v1/game/2017021058/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-11T03:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 39,
            ""losses"" : 23,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 30,
            ""losses"" : 34,
            ""ot"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 22,
            ""name"" : ""Edmonton Oilers"",
            ""link"" : ""/api/v1/teams/22""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5100,
        ""name"" : ""Rogers Place"",
        ""link"" : ""/api/v1/venues/5100""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021058/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-13"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021075,
      ""link"" : ""/api/v1/game/2017021075/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-14T00:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 37,
            ""losses"" : 24,
            ""ot"" : 8,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 21,
            ""name"" : ""Colorado Avalanche"",
            ""link"" : ""/api/v1/teams/21""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 39,
            ""losses"" : 24,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021075/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-16"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021097,
      ""link"" : ""/api/v1/game/2017021097/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-17T02:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 40,
            ""losses"" : 24,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 45,
            ""losses"" : 21,
            ""ot"" : 5,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 54,
            ""name"" : ""Vegas Golden Knights"",
            ""link"" : ""/api/v1/teams/54""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5178,
        ""name"" : ""T-Mobile Arena"",
        ""link"" : ""/api/v1/venues/5178""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021097/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-17"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021106,
      ""link"" : ""/api/v1/game/2017021106/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-18T01:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 41,
            ""losses"" : 24,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 23,
            ""losses"" : 37,
            ""ot"" : 11,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 53,
            ""name"" : ""Arizona Coyotes"",
            ""link"" : ""/api/v1/teams/53""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5043,
        ""name"" : ""Gila River Arena"",
        ""link"" : ""/api/v1/venues/5043""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021106/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-19"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021119,
      ""link"" : ""/api/v1/game/2017021119/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-20T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 40,
            ""losses"" : 27,
            ""ot"" : 6,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 26,
            ""name"" : ""Los Angeles Kings"",
            ""link"" : ""/api/v1/teams/26""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 41,
            ""losses"" : 24,
            ""ot"" : 8,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021119/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-24"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021161,
      ""link"" : ""/api/v1/game/2017021161/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-25T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 48,
            ""losses"" : 16,
            ""ot"" : 10,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 18,
            ""name"" : ""Nashville Predators"",
            ""link"" : ""/api/v1/teams/18""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 42,
            ""losses"" : 24,
            ""ot"" : 8,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021161/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-25"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021166,
      ""link"" : ""/api/v1/game/2017021166/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-25T23:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 47,
            ""losses"" : 17,
            ""ot"" : 10,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 6,
            ""name"" : ""Boston Bruins"",
            ""link"" : ""/api/v1/teams/6""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 42,
            ""losses"" : 24,
            ""ot"" : 9,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021166/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-27"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021181,
      ""link"" : ""/api/v1/game/2017021181/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-28T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 42,
            ""losses"" : 24,
            ""ot"" : 10,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 49,
            ""losses"" : 16,
            ""ot"" : 11,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 18,
            ""name"" : ""Nashville Predators"",
            ""link"" : ""/api/v1/teams/18""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5030,
        ""name"" : ""Bridgestone Arena"",
        ""link"" : ""/api/v1/venues/5030""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021181/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-29"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021195,
      ""link"" : ""/api/v1/game/2017021195/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-03-30T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 39,
            ""losses"" : 31,
            ""ot"" : 8,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 25,
            ""name"" : ""Dallas Stars"",
            ""link"" : ""/api/v1/teams/25""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 43,
            ""losses"" : 24,
            ""ot"" : 10,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021195/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-03-31"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021214,
      ""link"" : ""/api/v1/game/2017021214/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-04-01T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 43,
            ""losses"" : 25,
            ""ot"" : 10,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 40,
            ""losses"" : 31,
            ""ot"" : 8,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 25,
            ""name"" : ""Dallas Stars"",
            ""link"" : ""/api/v1/teams/25""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5019,
        ""name"" : ""American Airlines Center"",
        ""link"" : ""/api/v1/venues/5019""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021214/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-04-02"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021227,
      ""link"" : ""/api/v1/game/2017021227/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-04-03T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 34,
            ""losses"" : 40,
            ""ot"" : 6,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 22,
            ""name"" : ""Edmonton Oilers"",
            ""link"" : ""/api/v1/teams/22""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 44,
            ""losses"" : 25,
            ""ot"" : 10,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021227/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-04-04"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021240,
      ""link"" : ""/api/v1/game/2017021240/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-04-05T02:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 44,
            ""losses"" : 26,
            ""ot"" : 10,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 42,
            ""losses"" : 25,
            ""ot"" : 13,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 24,
            ""name"" : ""Anaheim Ducks"",
            ""link"" : ""/api/v1/teams/24""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5046,
        ""name"" : ""Honda Center"",
        ""link"" : ""/api/v1/venues/5046""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021240/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-04-05"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021251,
      ""link"" : ""/api/v1/game/2017021251/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-04-06T02:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 44,
            ""losses"" : 26,
            ""ot"" : 11,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 45,
            ""losses"" : 28,
            ""ot"" : 8,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 26,
            ""name"" : ""Los Angeles Kings"",
            ""link"" : ""/api/v1/teams/26""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5081,
        ""name"" : ""STAPLES Center"",
        ""link"" : ""/api/v1/venues/5081""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021251/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-04-07"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017021271,
      ""link"" : ""/api/v1/game/2017021271/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-04-08T02:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 45,
            ""losses"" : 26,
            ""ot"" : 11,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 45,
            ""losses"" : 27,
            ""ot"" : 10,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 28,
            ""name"" : ""San Jose Sharks"",
            ""link"" : ""/api/v1/teams/28""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""SAP Center at San Jose"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017021271/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-04-11"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017030161,
      ""link"" : ""/api/v1/game/2017030161/feed/live"",
      ""gameType"" : ""P"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-04-11T23:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 0,
            ""losses"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 1,
            ""losses"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 3,
          ""team"" : {
            ""id"" : 52,
            ""name"" : ""Winnipeg Jets"",
            ""link"" : ""/api/v1/teams/52""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Bell MTS Place"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017030161/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-04-13"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017030162,
      ""link"" : ""/api/v1/game/2017030162/feed/live"",
      ""gameType"" : ""P"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-04-13T23:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 0,
            ""losses"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 2,
            ""losses"" : 0,
            ""type"" : ""league""
          },
          ""score"" : 4,
          ""team"" : {
            ""id"" : 52,
            ""name"" : ""Winnipeg Jets"",
            ""link"" : ""/api/v1/teams/52""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Bell MTS Place"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017030162/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-04-15"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017030163,
      ""link"" : ""/api/v1/game/2017030163/feed/live"",
      ""gameType"" : ""P"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-04-15T23:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 2,
            ""losses"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 52,
            ""name"" : ""Winnipeg Jets"",
            ""link"" : ""/api/v1/teams/52""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 1,
            ""losses"" : 2,
            ""type"" : ""league""
          },
          ""score"" : 6,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017030163/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-04-17"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017030164,
      ""link"" : ""/api/v1/game/2017030164/feed/live"",
      ""gameType"" : ""P"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-04-18T00:00:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 3,
            ""losses"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 52,
            ""name"" : ""Winnipeg Jets"",
            ""link"" : ""/api/v1/teams/52""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 1,
            ""losses"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017030164/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2018-04-20"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2017030165,
      ""link"" : ""/api/v1/game/2017030165/feed/live"",
      ""gameType"" : ""P"",
      ""season"" : ""20172018"",
      ""gameDate"" : ""2018-04-20T23:30:00Z"",
      ""status"" : {
        ""abstractGameState"" : ""Final"",
        ""codedGameState"" : ""7"",
        ""detailedState"" : ""Final"",
        ""statusCode"" : ""7"",
        ""startTimeTBD"" : false
      },
      ""teams"" : {
        ""away"" : {
          ""leagueRecord"" : {
            ""wins"" : 1,
            ""losses"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 0,
          ""team"" : {
            ""id"" : 30,
            ""name"" : ""Minnesota Wild"",
            ""link"" : ""/api/v1/teams/30""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 4,
            ""losses"" : 1,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 52,
            ""name"" : ""Winnipeg Jets"",
            ""link"" : ""/api/v1/teams/52""
          }
        }
      },
      ""venue"" : {
        ""name"" : ""Bell MTS Place"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2017030165/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  } ]
}
                ";
            }
        }
    }
}
