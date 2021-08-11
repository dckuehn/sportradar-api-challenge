using System;
using System.Collections.Generic;
using System.Text;

namespace XUnit.SportradarApiChallenge.SampleApiResponses
{
    public class SampleScheduleWithLinescore
    {
        public static string MinnesotaWild_Schedule_With_Linescores
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
    ""timeStamp"" : ""20210811_190449""
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
      ""linescore"" : {
        ""currentPeriod"" : 5,
        ""currentPeriodOrdinal"" : ""SO"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-19T00:07:54Z"",
          ""endTime"" : ""2017-09-19T00:48:04Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-19T01:06:35Z"",
          ""endTime"" : ""2017-09-19T01:44:07Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-19T02:02:35Z"",
          ""endTime"" : ""2017-09-19T02:39:56Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2017-09-19T02:42:08Z"",
          ""endTime"" : ""2017-09-19T02:50:12Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 1,
            ""attempts"" : 3
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 3
          },
          ""startTime"" : ""2017-09-19T02:52:10Z""
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 52,
              ""name"" : ""Winnipeg Jets"",
              ""link"" : ""/api/v1/teams/52""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 43,
            ""goaliePulled"" : false,
            ""numSkaters"" : 1,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 36,
            ""goaliePulled"" : false,
            ""numSkaters"" : 0,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : true,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 300,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-22T00:10:00Z"",
          ""endTime"" : ""2017-09-22T00:41:11Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-22T00:59:52Z"",
          ""endTime"" : ""2017-09-22T01:35:31Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-22T01:54:04Z"",
          ""endTime"" : ""2017-09-22T02:28:32Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 23,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 52,
              ""name"" : ""Winnipeg Jets"",
              ""link"" : ""/api/v1/teams/52""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 21,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 5,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-23T22:08:31Z"",
          ""endTime"" : ""2017-09-23T22:43:27Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-23T23:01:51Z"",
          ""endTime"" : ""2017-09-23T23:40:45Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-23T23:59:20Z"",
          ""endTime"" : ""2017-09-24T00:34:49Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 24,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 21,
              ""name"" : ""Colorado Avalanche"",
              ""link"" : ""/api/v1/teams/21""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-24T23:08:27Z"",
          ""endTime"" : ""2017-09-24T23:48:24Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-25T00:06:58Z"",
          ""endTime"" : ""2017-09-25T00:40:54Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-25T00:59:30Z"",
          ""endTime"" : ""2017-09-25T01:37:04Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 21,
              ""name"" : ""Colorado Avalanche"",
              ""link"" : ""/api/v1/teams/21""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 39,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 38,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-27T00:37:44Z"",
          ""endTime"" : ""2017-09-27T01:17:26Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-27T01:35:35Z"",
          ""endTime"" : ""2017-09-27T02:12:29Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-09-27T02:30:36Z"",
          ""endTime"" : ""2017-09-27T03:06:42Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 25,
              ""name"" : ""Dallas Stars"",
              ""link"" : ""/api/v1/teams/25""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 37,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 33,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 163,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 19,
              ""name"" : ""St. Louis Blues"",
              ""link"" : ""/api/v1/teams/19""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 0,
            ""goaliePulled"" : false,
            ""numSkaters"" : 0,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 0,
            ""goaliePulled"" : false,
            ""numSkaters"" : 0,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-01T00:08:31Z"",
          ""endTime"" : ""2017-10-01T00:47:46Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-01T01:06:14Z"",
          ""endTime"" : ""2017-10-01T01:41:55Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-01T02:00:31Z"",
          ""endTime"" : ""2017-10-01T02:37:56Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 24,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 25,
              ""name"" : ""Dallas Stars"",
              ""link"" : ""/api/v1/teams/25""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-05T23:47:57Z"",
          ""endTime"" : ""2017-10-06T00:33:13Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-06T00:51:35Z"",
          ""endTime"" : ""2017-10-06T01:28:53Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-06T01:47:17Z"",
          ""endTime"" : ""2017-10-06T02:26:42Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 17,
              ""name"" : ""Detroit Red Wings"",
              ""link"" : ""/api/v1/teams/17""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 39,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 5,
        ""currentPeriodOrdinal"" : ""SO"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-07T23:15:02Z"",
          ""endTime"" : ""2017-10-07T23:53:00Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-08T00:11:26Z"",
          ""endTime"" : ""2017-10-08T00:52:05Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 17,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-08T01:10:42Z"",
          ""endTime"" : ""2017-10-08T01:55:13Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2017-10-08T01:57:20Z"",
          ""endTime"" : ""2017-10-08T02:03:47Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 1,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 3
          },
          ""home"" : {
            ""scores"" : 1,
            ""attempts"" : 3
          },
          ""startTime"" : ""2017-10-08T02:05:44Z""
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 12,
              ""name"" : ""Carolina Hurricanes"",
              ""link"" : ""/api/v1/teams/12""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 42,
            ""goaliePulled"" : false,
            ""numSkaters"" : 0,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 1,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : true,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 300,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-13T00:38:40Z"",
          ""endTime"" : ""2017-10-13T01:10:50Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-13T01:29:23Z"",
          ""endTime"" : ""2017-10-13T02:06:49Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-13T02:25:18Z"",
          ""endTime"" : ""2017-10-13T03:12:12Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 4,
            ""shotsOnGoal"" : 17,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 16,
              ""name"" : ""Chicago Blackhawks"",
              ""link"" : ""/api/v1/teams/16""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 38,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 34,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-15T00:12:59Z"",
          ""endTime"" : ""2017-10-15T00:50:19Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-15T01:08:40Z"",
          ""endTime"" : ""2017-10-15T01:47:34Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-15T02:06:04Z"",
          ""endTime"" : ""2017-10-15T02:46:34Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2017-10-15T02:48:30Z"",
          ""endTime"" : ""2017-10-15T02:52:11Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 21,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 29,
              ""name"" : ""Columbus Blue Jackets"",
              ""link"" : ""/api/v1/teams/29""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 35,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 300,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-21T00:08:32Z"",
          ""endTime"" : ""2017-10-21T00:47:20Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-21T01:05:36Z"",
          ""endTime"" : ""2017-10-21T01:43:28Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-21T02:01:49Z"",
          ""endTime"" : ""2017-10-21T02:41:21Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 52,
              ""name"" : ""Winnipeg Jets"",
              ""link"" : ""/api/v1/teams/52""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-22T02:09:18Z"",
          ""endTime"" : ""2017-10-22T02:44:37Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 18,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-22T03:02:54Z"",
          ""endTime"" : ""2017-10-22T03:44:32Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-22T04:02:53Z"",
          ""endTime"" : ""2017-10-22T04:43:17Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 20,
              ""name"" : ""Calgary Flames"",
              ""link"" : ""/api/v1/teams/20""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 37,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 32,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 63,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-25T00:08:15Z"",
          ""endTime"" : ""2017-10-25T00:44:30Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-25T01:03:01Z"",
          ""endTime"" : ""2017-10-25T01:43:05Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-25T02:01:20Z"",
          ""endTime"" : ""2017-10-25T02:40:53Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 23,
              ""name"" : ""Vancouver Canucks"",
              ""link"" : ""/api/v1/teams/23""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 25,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-27T00:08:33Z"",
          ""endTime"" : ""2017-10-27T00:51:15Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-27T01:10:05Z"",
          ""endTime"" : ""2017-10-27T01:43:42Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-27T02:02:06Z"",
          ""endTime"" : ""2017-10-27T02:40:47Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 33,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 2,
              ""name"" : ""New York Islanders"",
              ""link"" : ""/api/v1/teams/2""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 33,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 873,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-29T00:08:11Z"",
          ""endTime"" : ""2017-10-29T00:44:55Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-29T01:04:06Z"",
          ""endTime"" : ""2017-10-29T01:39:00Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-10-29T01:57:05Z"",
          ""endTime"" : ""2017-10-29T02:33:18Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 5,
              ""name"" : ""Pittsburgh Penguins"",
              ""link"" : ""/api/v1/teams/5""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-01T00:08:34Z"",
          ""endTime"" : ""2017-11-01T00:49:32Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-01T01:08:16Z"",
          ""endTime"" : ""2017-11-01T01:43:45Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-01T02:02:25Z"",
          ""endTime"" : ""2017-11-01T02:37:30Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 52,
              ""name"" : ""Winnipeg Jets"",
              ""link"" : ""/api/v1/teams/52""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 19,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-03T00:07:36Z"",
          ""endTime"" : ""2017-11-03T00:47:06Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-03T01:05:39Z"",
          ""endTime"" : ""2017-11-03T01:42:42Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-03T02:01:10Z"",
          ""endTime"" : ""2017-11-03T02:43:18Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 8,
              ""name"" : ""Montréal Canadiens"",
              ""link"" : ""/api/v1/teams/8""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 6,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-05T00:08:31Z"",
          ""endTime"" : ""2017-11-05T00:45:57Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-05T01:04:31Z"",
          ""endTime"" : ""2017-11-05T01:37:29Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-05T01:56:13Z"",
          ""endTime"" : ""2017-11-05T03:34:43Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 24,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 16,
              ""name"" : ""Chicago Blackhawks"",
              ""link"" : ""/api/v1/teams/16""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 35,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-07T00:12:50Z"",
          ""endTime"" : ""2017-11-07T00:54:03Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-07T01:12:12Z"",
          ""endTime"" : ""2017-11-07T01:53:07Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-07T02:11:18Z"",
          ""endTime"" : ""2017-11-07T02:52:09Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 6,
              ""name"" : ""Boston Bruins"",
              ""link"" : ""/api/v1/teams/6""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 34,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 49,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-09T00:43:29Z"",
          ""endTime"" : ""2017-11-09T01:20:03Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-09T01:37:55Z"",
          ""endTime"" : ""2017-11-09T02:14:58Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-09T02:33:01Z"",
          ""endTime"" : ""2017-11-09T03:12:57Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 10,
              ""name"" : ""Toronto Maple Leafs"",
              ""link"" : ""/api/v1/teams/10""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 19,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 37,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 31,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-10T00:38:02Z"",
          ""endTime"" : ""2017-11-10T01:20:22Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-10T01:38:41Z"",
          ""endTime"" : ""2017-11-10T02:15:11Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 17,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-10T02:33:33Z"",
          ""endTime"" : ""2017-11-10T03:20:09Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 8,
              ""name"" : ""Montréal Canadiens"",
              ""link"" : ""/api/v1/teams/8""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 41,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 35,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 35,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-12T00:09:00Z"",
          ""endTime"" : ""2017-11-12T00:41:44Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-12T01:00:05Z"",
          ""endTime"" : ""2017-11-12T01:35:33Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-12T01:53:53Z"",
          ""endTime"" : ""2017-11-12T02:34:05Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 4,
              ""name"" : ""Philadelphia Flyers"",
              ""link"" : ""/api/v1/teams/4""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 32,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-15T01:08:46Z"",
          ""endTime"" : ""2017-11-15T01:45:37Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-15T02:04:18Z"",
          ""endTime"" : ""2017-11-15T02:36:58Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 17,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-15T02:55:35Z"",
          ""endTime"" : ""2017-11-15T03:28:17Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 20,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 4,
              ""name"" : ""Philadelphia Flyers"",
              ""link"" : ""/api/v1/teams/4""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 37,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-17T01:08:45Z"",
          ""endTime"" : ""2017-11-17T01:46:04Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-17T02:04:26Z"",
          ""endTime"" : ""2017-11-17T02:49:48Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-17T03:08:11Z"",
          ""endTime"" : ""2017-11-17T03:51:50Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 4,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 36,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 18,
              ""name"" : ""Nashville Predators"",
              ""link"" : ""/api/v1/teams/18""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-19T00:38:14Z"",
          ""endTime"" : ""2017-11-19T01:12:56Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-19T01:31:16Z"",
          ""endTime"" : ""2017-11-19T02:11:44Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-19T02:30:05Z"",
          ""endTime"" : ""2017-11-19T03:12:49Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 22,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 15,
              ""name"" : ""Washington Capitals"",
              ""link"" : ""/api/v1/teams/15""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 43,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-21T01:08:55Z"",
          ""endTime"" : ""2017-11-21T01:56:22Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 3,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-21T02:05:20Z"",
          ""endTime"" : ""2017-11-21T02:41:45Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-21T03:00:33Z"",
          ""endTime"" : ""2017-11-21T03:46:17Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2017-11-21T03:48:22Z"",
          ""endTime"" : ""2017-11-21T03:49:53Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 1,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 36,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 1,
              ""name"" : ""New Jersey Devils"",
              ""link"" : ""/api/v1/teams/1""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 25,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 300,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-23T00:08:23Z"",
          ""endTime"" : ""2017-11-23T00:46:15Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-23T01:04:32Z"",
          ""endTime"" : ""2017-11-23T01:45:12Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-23T02:03:35Z"",
          ""endTime"" : ""2017-11-23T02:37:53Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 7,
              ""name"" : ""Buffalo Sabres"",
              ""link"" : ""/api/v1/teams/7""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 34,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 32,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 5,
        ""currentPeriodOrdinal"" : ""SO"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-24T21:08:30Z"",
          ""endTime"" : ""2017-11-24T21:45:40Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-24T22:04:16Z"",
          ""endTime"" : ""2017-11-24T22:40:18Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-24T22:59:12Z"",
          ""endTime"" : ""2017-11-24T23:28:11Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 3,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2017-11-24T23:30:12Z"",
          ""endTime"" : ""2017-11-24T23:37:11Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 2
          },
          ""home"" : {
            ""scores"" : 2,
            ""attempts"" : 3
          },
          ""startTime"" : ""2017-11-24T23:39:11Z""
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 1,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 21,
              ""name"" : ""Colorado Avalanche"",
              ""link"" : ""/api/v1/teams/21""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 0,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : true,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 300,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-26T01:08:03Z"",
          ""endTime"" : ""2017-11-26T01:47:49Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-26T02:06:19Z"",
          ""endTime"" : ""2017-11-26T02:43:34Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 19,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-26T03:02:01Z"",
          ""endTime"" : ""2017-11-26T03:38:49Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 19,
              ""name"" : ""St. Louis Blues"",
              ""link"" : ""/api/v1/teams/19""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 40,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 25,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-28T01:14:52Z"",
          ""endTime"" : ""2017-11-28T01:51:14Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-28T02:10:20Z"",
          ""endTime"" : ""2017-11-28T02:50:32Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-11-28T03:08:52Z"",
          ""endTime"" : ""2017-11-28T03:51:33Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 52,
              ""name"" : ""Winnipeg Jets"",
              ""link"" : ""/api/v1/teams/52""
            },
            ""goals"" : 7,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 19,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 607,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-01T01:08:49Z"",
          ""endTime"" : ""2017-12-01T01:44:46Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-01T02:03:13Z"",
          ""endTime"" : ""2017-12-01T02:39:49Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-01T02:58:11Z"",
          ""endTime"" : ""2017-12-01T03:34:39Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 32,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 54,
              ""name"" : ""Vegas Golden Knights"",
              ""link"" : ""/api/v1/teams/54""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-02T23:08:42Z"",
          ""endTime"" : ""2017-12-02T23:44:50Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-03T00:03:41Z"",
          ""endTime"" : ""2017-12-03T00:37:01Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-03T00:55:44Z"",
          ""endTime"" : ""2017-12-03T01:34:39Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2017-12-03T01:36:47Z"",
          ""endTime"" : ""2017-12-03T01:38:21Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 1,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 1,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 25,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 19,
              ""name"" : ""St. Louis Blues"",
              ""link"" : ""/api/v1/teams/19""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 42,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-06T03:15:24Z"",
          ""endTime"" : ""2017-12-06T03:55:19Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-06T04:13:37Z"",
          ""endTime"" : ""2017-12-06T04:51:58Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-06T05:10:22Z"",
          ""endTime"" : ""2017-12-06T05:49:02Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 4,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 26,
              ""name"" : ""Los Angeles Kings"",
              ""link"" : ""/api/v1/teams/26""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 21,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 56,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-09T03:08:05Z"",
          ""endTime"" : ""2017-12-09T03:42:05Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-09T04:00:36Z"",
          ""endTime"" : ""2017-12-09T04:31:06Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-09T04:49:41Z"",
          ""endTime"" : ""2017-12-09T05:26:38Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2017-12-09T05:28:30Z"",
          ""endTime"" : ""2017-12-09T05:33:13Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 1,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 24,
              ""name"" : ""Anaheim Ducks"",
              ""link"" : ""/api/v1/teams/24""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-11T02:08:33Z"",
          ""endTime"" : ""2017-12-11T02:44:16Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-11T03:02:26Z"",
          ""endTime"" : ""2017-12-11T03:45:35Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-11T04:03:44Z"",
          ""endTime"" : ""2017-12-11T04:37:36Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2017-12-11T04:39:57Z"",
          ""endTime"" : ""2017-12-11T04:44:35Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 1,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 28,
              ""name"" : ""San Jose Sharks"",
              ""link"" : ""/api/v1/teams/28""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 34,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 24,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 5,
        ""currentPeriodOrdinal"" : ""SO"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-13T01:08:41Z"",
          ""endTime"" : ""2017-12-13T01:41:56Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-13T02:00:29Z"",
          ""endTime"" : ""2017-12-13T02:35:31Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-13T02:53:58Z"",
          ""endTime"" : ""2017-12-13T03:28:13Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2017-12-13T03:30:26Z"",
          ""endTime"" : ""2017-12-13T03:37:03Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 1,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 3,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 1,
            ""attempts"" : 5
          },
          ""home"" : {
            ""scores"" : 2,
            ""attempts"" : 5
          },
          ""startTime"" : ""2017-12-13T03:38:49Z""
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 22,
            ""goaliePulled"" : false,
            ""numSkaters"" : 0,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 20,
              ""name"" : ""Calgary Flames"",
              ""link"" : ""/api/v1/teams/20""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 1,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : true,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 300,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-15T01:08:51Z"",
          ""endTime"" : ""2017-12-15T01:46:08Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-15T02:04:52Z"",
          ""endTime"" : ""2017-12-15T02:43:29Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-15T03:02:09Z"",
          ""endTime"" : ""2017-12-15T03:38:13Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 26,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 10,
              ""name"" : ""Toronto Maple Leafs"",
              ""link"" : ""/api/v1/teams/10""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-16T19:08:28Z"",
          ""endTime"" : ""2017-12-16T19:46:52Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-16T20:05:23Z"",
          ""endTime"" : ""2017-12-16T20:42:10Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-16T21:00:50Z"",
          ""endTime"" : ""2017-12-16T21:37:54Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 22,
              ""name"" : ""Edmonton Oilers"",
              ""link"" : ""/api/v1/teams/22""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-18T00:08:46Z"",
          ""endTime"" : ""2017-12-18T00:42:48Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-18T01:01:21Z"",
          ""endTime"" : ""2017-12-18T01:38:41Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 22,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-18T01:57:56Z"",
          ""endTime"" : ""2017-12-18T02:34:46Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 16,
              ""name"" : ""Chicago Blackhawks"",
              ""link"" : ""/api/v1/teams/16""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 46,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 210,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-20T00:07:39Z"",
          ""endTime"" : ""2017-12-20T00:43:43Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-20T01:02:23Z"",
          ""endTime"" : ""2017-12-20T01:38:42Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 17,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-20T01:57:11Z"",
          ""endTime"" : ""2017-12-20T02:36:39Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 9,
              ""name"" : ""Ottawa Senators"",
              ""link"" : ""/api/v1/teams/9""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 32,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 40,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-23T00:38:43Z"",
          ""endTime"" : ""2017-12-23T01:18:51Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-23T01:37:03Z"",
          ""endTime"" : ""2017-12-23T02:25:30Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-23T02:40:09Z"",
          ""endTime"" : ""2017-12-23T03:23:59Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 13,
              ""name"" : ""Florida Panthers"",
              ""link"" : ""/api/v1/teams/13""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 34,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 6,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-24T00:10:36Z"",
          ""endTime"" : ""2017-12-24T00:49:28Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-24T01:07:43Z"",
          ""endTime"" : ""2017-12-24T01:42:00Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-24T02:00:08Z"",
          ""endTime"" : ""2017-12-24T02:42:00Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 14,
              ""name"" : ""Tampa Bay Lightning"",
              ""link"" : ""/api/v1/teams/14""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 22,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 142,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-28T01:09:02Z"",
          ""endTime"" : ""2017-12-28T01:47:49Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-28T02:06:28Z"",
          ""endTime"" : ""2017-12-28T02:49:03Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-28T03:05:26Z"",
          ""endTime"" : ""2017-12-28T03:40:15Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 25,
              ""name"" : ""Dallas Stars"",
              ""link"" : ""/api/v1/teams/25""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 26,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-30T01:10:45Z"",
          ""endTime"" : ""2017-12-30T01:51:03Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 18,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-30T02:09:30Z"",
          ""endTime"" : ""2017-12-30T02:50:18Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 18,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-30T03:08:53Z"",
          ""endTime"" : ""2017-12-30T03:50:09Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 38,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 18,
              ""name"" : ""Nashville Predators"",
              ""link"" : ""/api/v1/teams/18""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 43,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-31T01:08:12Z"",
          ""endTime"" : ""2017-12-31T01:43:29Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-31T02:01:55Z"",
          ""endTime"" : ""2017-12-31T02:33:44Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2017-12-31T02:52:13Z"",
          ""endTime"" : ""2017-12-31T03:29:53Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 18,
              ""name"" : ""Nashville Predators"",
              ""link"" : ""/api/v1/teams/18""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 140,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-03T01:08:44Z"",
          ""endTime"" : ""2018-01-03T01:44:06Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-03T02:03:03Z"",
          ""endTime"" : ""2018-01-03T02:48:52Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 19,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-03T03:07:33Z"",
          ""endTime"" : ""2018-01-03T03:43:39Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 41,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 13,
              ""name"" : ""Florida Panthers"",
              ""link"" : ""/api/v1/teams/13""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 26,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-05T01:08:24Z"",
          ""endTime"" : ""2018-01-05T01:41:02Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-05T01:59:40Z"",
          ""endTime"" : ""2018-01-05T02:34:53Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-05T02:53:30Z"",
          ""endTime"" : ""2018-01-05T03:29:33Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 7,
              ""name"" : ""Buffalo Sabres"",
              ""link"" : ""/api/v1/teams/7""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 105,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-07T02:15:52Z"",
          ""endTime"" : ""2018-01-07T02:51:51Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-07T03:10:37Z"",
          ""endTime"" : ""2018-01-07T03:51:15Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-07T04:09:42Z"",
          ""endTime"" : ""2018-01-07T04:53:38Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 21,
              ""name"" : ""Colorado Avalanche"",
              ""link"" : ""/api/v1/teams/21""
            },
            ""goals"" : 7,
            ""shotsOnGoal"" : 38,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 36,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 197,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-10T01:08:20Z"",
          ""endTime"" : ""2018-01-10T01:45:52Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-10T02:04:32Z"",
          ""endTime"" : ""2018-01-10T02:41:15Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-10T02:59:40Z"",
          ""endTime"" : ""2018-01-10T03:43:53Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2018-01-10T03:46:10Z"",
          ""endTime"" : ""2018-01-10T03:51:16Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 35,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 20,
              ""name"" : ""Calgary Flames"",
              ""link"" : ""/api/v1/teams/20""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 300,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-11T01:10:06Z"",
          ""endTime"" : ""2018-01-11T01:52:43Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-11T02:11:08Z"",
          ""endTime"" : ""2018-01-11T02:47:42Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-11T03:06:07Z"",
          ""endTime"" : ""2018-01-11T03:43:51Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 16,
              ""name"" : ""Chicago Blackhawks"",
              ""link"" : ""/api/v1/teams/16""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 35,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-14T00:15:17Z"",
          ""endTime"" : ""2018-01-14T00:52:19Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 23,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-14T01:11:04Z"",
          ""endTime"" : ""2018-01-14T01:46:51Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 17,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-14T02:05:39Z"",
          ""endTime"" : ""2018-01-14T02:41:43Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 41,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 52,
              ""name"" : ""Winnipeg Jets"",
              ""link"" : ""/api/v1/teams/52""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 33,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 1153,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-15T01:10:33Z"",
          ""endTime"" : ""2018-01-15T01:43:28Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-15T02:02:05Z"",
          ""endTime"" : ""2018-01-15T02:37:15Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-15T02:56:06Z"",
          ""endTime"" : ""2018-01-15T03:31:05Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2018-01-15T03:33:28Z"",
          ""endTime"" : ""2018-01-15T03:37:17Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 23,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 23,
              ""name"" : ""Vancouver Canucks"",
              ""link"" : ""/api/v1/teams/23""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 25,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 300,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-21T02:08:24Z"",
          ""endTime"" : ""2018-01-21T02:48:20Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-21T03:06:56Z"",
          ""endTime"" : ""2018-01-21T03:42:54Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-21T04:01:31Z"",
          ""endTime"" : ""2018-01-21T04:43:34Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 35,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 14,
              ""name"" : ""Tampa Bay Lightning"",
              ""link"" : ""/api/v1/teams/14""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 23,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-23T01:10:34Z"",
          ""endTime"" : ""2018-01-23T01:50:46Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-23T02:09:22Z"",
          ""endTime"" : ""2018-01-23T02:45:43Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-23T03:04:10Z"",
          ""endTime"" : ""2018-01-23T03:39:29Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 36,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 9,
              ""name"" : ""Ottawa Senators"",
              ""link"" : ""/api/v1/teams/9""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 38,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-26T00:08:03Z"",
          ""endTime"" : ""2018-01-26T00:40:55Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-26T00:59:16Z"",
          ""endTime"" : ""2018-01-26T01:39:59Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-26T01:58:15Z"",
          ""endTime"" : ""2018-01-26T02:37:44Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 5,
              ""name"" : ""Pittsburgh Penguins"",
              ""link"" : ""/api/v1/teams/5""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 39,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 26,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 550,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 5,
        ""currentPeriodOrdinal"" : ""SO"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-31T00:09:22Z"",
          ""endTime"" : ""2018-01-31T00:45:37Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-31T01:03:54Z"",
          ""endTime"" : ""2018-01-31T01:43:06Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 20,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-01-31T02:01:42Z"",
          ""endTime"" : ""2018-01-31T02:38:35Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2018-01-31T02:40:54Z"",
          ""endTime"" : ""2018-01-31T02:47:49Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 3,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 2,
            ""attempts"" : 4
          },
          ""home"" : {
            ""scores"" : 1,
            ""attempts"" : 4
          },
          ""startTime"" : ""2018-01-31T02:49:43Z""
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 29,
              ""name"" : ""Columbus Blue Jackets"",
              ""link"" : ""/api/v1/teams/29""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 0,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 43,
            ""goaliePulled"" : false,
            ""numSkaters"" : 1,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : true,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 300,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-03T01:10:23Z"",
          ""endTime"" : ""2018-02-03T01:46:38Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 19,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-03T02:05:11Z"",
          ""endTime"" : ""2018-02-03T02:43:31Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-03T03:02:10Z"",
          ""endTime"" : ""2018-02-03T03:37:10Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 36,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 54,
              ""name"" : ""Vegas Golden Knights"",
              ""link"" : ""/api/v1/teams/54""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 24,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 89,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-04T01:09:42Z"",
          ""endTime"" : ""2018-02-04T01:44:03Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-04T02:02:14Z"",
          ""endTime"" : ""2018-02-04T02:41:50Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 4,
            ""shotsOnGoal"" : 20,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-04T03:00:12Z"",
          ""endTime"" : ""2018-02-04T03:33:51Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 25,
              ""name"" : ""Dallas Stars"",
              ""link"" : ""/api/v1/teams/25""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 38,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 380,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-07T01:10:51Z"",
          ""endTime"" : ""2018-02-07T01:49:06Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-07T02:07:42Z"",
          ""endTime"" : ""2018-02-07T02:45:46Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-07T03:04:17Z"",
          ""endTime"" : ""2018-02-07T03:46:27Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 19,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 3,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 19,
              ""name"" : ""St. Louis Blues"",
              ""link"" : ""/api/v1/teams/19""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 37,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 20,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-09T01:08:10Z"",
          ""endTime"" : ""2018-02-09T01:47:28Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-09T02:06:08Z"",
          ""endTime"" : ""2018-02-09T02:43:35Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-09T03:02:16Z"",
          ""endTime"" : ""2018-02-09T03:36:59Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2018-02-09T03:39:01Z"",
          ""endTime"" : ""2018-02-09T03:43:37Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 3,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 53,
              ""name"" : ""Arizona Coyotes"",
              ""link"" : ""/api/v1/teams/53""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 40,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 300,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-11T01:08:33Z"",
          ""endTime"" : ""2018-02-11T01:50:43Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 17,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-11T02:09:13Z"",
          ""endTime"" : ""2018-02-11T02:46:09Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-11T03:04:52Z"",
          ""endTime"" : ""2018-02-11T03:43:31Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 19,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 16,
              ""name"" : ""Chicago Blackhawks"",
              ""link"" : ""/api/v1/teams/16""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 44,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-14T01:08:35Z"",
          ""endTime"" : ""2018-02-14T01:47:23Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-14T02:06:04Z"",
          ""endTime"" : ""2018-02-14T02:45:28Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 19,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-14T03:04:17Z"",
          ""endTime"" : ""2018-02-14T03:35:42Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 3,
              ""name"" : ""New York Rangers"",
              ""link"" : ""/api/v1/teams/3""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 34,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-16T01:08:50Z"",
          ""endTime"" : ""2018-02-16T01:45:48Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-16T02:04:26Z"",
          ""endTime"" : ""2018-02-16T02:40:25Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-16T02:59:15Z"",
          ""endTime"" : ""2018-02-16T03:45:29Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 18,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 34,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 15,
              ""name"" : ""Washington Capitals"",
              ""link"" : ""/api/v1/teams/15""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 5,
        ""currentPeriodOrdinal"" : ""SO"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-17T19:08:29Z"",
          ""endTime"" : ""2018-02-17T19:49:23Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-17T20:08:01Z"",
          ""endTime"" : ""2018-02-17T20:44:15Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-17T21:02:51Z"",
          ""endTime"" : ""2018-02-17T21:38:18Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2018-02-17T21:40:35Z"",
          ""endTime"" : ""2018-02-17T21:46:20Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 3,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 1,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 3,
            ""attempts"" : 11
          },
          ""home"" : {
            ""scores"" : 2,
            ""attempts"" : 11
          },
          ""startTime"" : ""2018-02-17T21:47:30Z""
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 38,
            ""goaliePulled"" : false,
            ""numSkaters"" : 0,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 24,
              ""name"" : ""Anaheim Ducks"",
              ""link"" : ""/api/v1/teams/24""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 1,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : true,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-19T18:08:45Z"",
          ""endTime"" : ""2018-02-19T18:49:07Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-19T19:07:38Z"",
          ""endTime"" : ""2018-02-19T19:44:19Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-19T20:01:46Z"",
          ""endTime"" : ""2018-02-19T20:41:04Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 17,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 2,
              ""name"" : ""New York Islanders"",
              ""link"" : ""/api/v1/teams/2""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 35,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 32,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-23T00:07:41Z"",
          ""endTime"" : ""2018-02-23T00:44:45Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 18,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-23T01:03:01Z"",
          ""endTime"" : ""2018-02-23T01:40:20Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-23T01:58:31Z"",
          ""endTime"" : ""2018-02-23T02:34:52Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 16,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 1,
              ""name"" : ""New Jersey Devils"",
              ""link"" : ""/api/v1/teams/1""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 40,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 25,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 10,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-24T00:08:12Z"",
          ""endTime"" : ""2018-02-24T00:41:59Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-24T01:00:17Z"",
          ""endTime"" : ""2018-02-24T01:36:07Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-24T01:54:16Z"",
          ""endTime"" : ""2018-02-24T02:28:48Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 3,
              ""name"" : ""New York Rangers"",
              ""link"" : ""/api/v1/teams/3""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 23,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 37,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 780,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-26T01:09:24Z"",
          ""endTime"" : ""2018-02-26T01:45:54Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 17,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-26T02:04:38Z"",
          ""endTime"" : ""2018-02-26T02:42:52Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 19,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-26T03:01:41Z"",
          ""endTime"" : ""2018-02-26T03:37:07Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2018-02-26T03:39:13Z"",
          ""endTime"" : ""2018-02-26T03:44:54Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 1,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 41,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 28,
              ""name"" : ""San Jose Sharks"",
              ""link"" : ""/api/v1/teams/28""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-28T01:10:41Z"",
          ""endTime"" : ""2018-02-28T01:47:36Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-28T02:06:03Z"",
          ""endTime"" : ""2018-02-28T02:45:25Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-02-28T03:05:18Z"",
          ""endTime"" : ""2018-02-28T03:39:12Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 8,
            ""shotsOnGoal"" : 33,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 19,
              ""name"" : ""St. Louis Blues"",
              ""link"" : ""/api/v1/teams/19""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 25,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-02T02:08:09Z"",
          ""endTime"" : ""2018-03-02T02:42:54Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-02T02:59:57Z"",
          ""endTime"" : ""2018-03-02T03:39:53Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-02T03:57:15Z"",
          ""endTime"" : ""2018-03-02T04:36:12Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 4,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 53,
              ""name"" : ""Arizona Coyotes"",
              ""link"" : ""/api/v1/teams/53""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 25,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 35,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 740,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-03T02:08:19Z"",
          ""endTime"" : ""2018-03-03T02:47:24Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-03T03:05:46Z"",
          ""endTime"" : ""2018-03-03T03:48:27Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 4,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-03T04:04:37Z"",
          ""endTime"" : ""2018-03-03T04:39:00Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 21,
              ""name"" : ""Colorado Avalanche"",
              ""link"" : ""/api/v1/teams/21""
            },
            ""goals"" : 7,
            ""shotsOnGoal"" : 26,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 32,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 130,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-05T00:10:20Z"",
          ""endTime"" : ""2018-03-05T00:47:31Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-05T01:06:14Z"",
          ""endTime"" : ""2018-03-05T01:44:59Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-05T02:03:29Z"",
          ""endTime"" : ""2018-03-05T02:36:19Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 17,
              ""name"" : ""Detroit Red Wings"",
              ""link"" : ""/api/v1/teams/17""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 218,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-07T01:09:08Z"",
          ""endTime"" : ""2018-03-07T01:48:50Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-07T02:07:40Z"",
          ""endTime"" : ""2018-03-07T02:47:12Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 4,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-07T03:05:33Z"",
          ""endTime"" : ""2018-03-07T03:38:02Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 12,
              ""name"" : ""Carolina Hurricanes"",
              ""link"" : ""/api/v1/teams/12""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-10T03:08:32Z"",
          ""endTime"" : ""2018-03-10T03:45:51Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-10T04:04:19Z"",
          ""endTime"" : ""2018-03-10T04:40:53Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-10T04:59:10Z"",
          ""endTime"" : ""2018-03-10T05:36:11Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 23,
              ""name"" : ""Vancouver Canucks"",
              ""link"" : ""/api/v1/teams/23""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 32,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 36,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 44,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-11T03:09:43Z"",
          ""endTime"" : ""2018-03-11T03:42:45Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-11T03:01:05Z"",
          ""endTime"" : ""2018-03-11T03:35:54Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-11T03:54:14Z"",
          ""endTime"" : ""2018-03-11T04:31:25Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 22,
              ""name"" : ""Edmonton Oilers"",
              ""link"" : ""/api/v1/teams/22""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 33,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 153,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-14T00:40:53Z"",
          ""endTime"" : ""2018-03-14T01:18:04Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-14T01:37:07Z"",
          ""endTime"" : ""2018-03-14T02:11:39Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-14T02:31:01Z"",
          ""endTime"" : ""2018-03-14T03:12:14Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 34,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 21,
              ""name"" : ""Colorado Avalanche"",
              ""link"" : ""/api/v1/teams/21""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 22,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 81,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-17T02:37:33Z"",
          ""endTime"" : ""2018-03-17T03:16:22Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-17T03:34:48Z"",
          ""endTime"" : ""2018-03-17T04:07:47Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-17T04:26:19Z"",
          ""endTime"" : ""2018-03-17T05:02:18Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 54,
              ""name"" : ""Vegas Golden Knights"",
              ""link"" : ""/api/v1/teams/54""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 34,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-18T01:08:19Z"",
          ""endTime"" : ""2018-03-18T01:43:43Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-18T02:02:01Z"",
          ""endTime"" : ""2018-03-18T02:37:45Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-18T02:56:10Z"",
          ""endTime"" : ""2018-03-18T03:33:55Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 53,
              ""name"" : ""Arizona Coyotes"",
              ""link"" : ""/api/v1/teams/53""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 33,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 18,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-20T00:11:12Z"",
          ""endTime"" : ""2018-03-20T00:45:12Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-20T01:03:45Z"",
          ""endTime"" : ""2018-03-20T01:43:15Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-20T02:01:48Z"",
          ""endTime"" : ""2018-03-20T02:39:49Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2018-03-20T02:42:10Z"",
          ""endTime"" : ""2018-03-20T02:47:39Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 26,
              ""name"" : ""Los Angeles Kings"",
              ""link"" : ""/api/v1/teams/26""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-25T00:08:41Z"",
          ""endTime"" : ""2018-03-25T00:43:24Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-25T01:01:56Z"",
          ""endTime"" : ""2018-03-25T01:38:15Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-25T01:56:58Z"",
          ""endTime"" : ""2018-03-25T02:39:30Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 18,
              ""name"" : ""Nashville Predators"",
              ""link"" : ""/api/v1/teams/18""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 20,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 101,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-25T23:40:46Z"",
          ""endTime"" : ""2018-03-26T00:19:39Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-26T00:38:14Z"",
          ""endTime"" : ""2018-03-26T01:17:41Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-26T01:36:19Z"",
          ""endTime"" : ""2018-03-26T02:10:14Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 3,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2018-03-26T02:12:34Z"",
          ""endTime"" : ""2018-03-26T02:13:22Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 1,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 25,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 6,
              ""name"" : ""Boston Bruins"",
              ""link"" : ""/api/v1/teams/6""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 5,
        ""currentPeriodOrdinal"" : ""SO"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-28T00:08:09Z"",
          ""endTime"" : ""2018-03-28T00:42:32Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-28T01:00:52Z"",
          ""endTime"" : ""2018-03-28T01:37:44Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-28T01:55:59Z"",
          ""endTime"" : ""2018-03-28T02:36:26Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2018-03-28T02:38:23Z"",
          ""endTime"" : ""2018-03-28T02:50:34Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 1,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 3,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 3
          },
          ""home"" : {
            ""scores"" : 1,
            ""attempts"" : 2
          },
          ""startTime"" : ""2018-03-28T02:52:10Z""
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 18,
              ""name"" : ""Nashville Predators"",
              ""link"" : ""/api/v1/teams/18""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 0,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 23,
            ""goaliePulled"" : false,
            ""numSkaters"" : 1,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : true,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 300,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-30T00:10:51Z"",
          ""endTime"" : ""2018-03-30T00:43:50Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-30T01:02:25Z"",
          ""endTime"" : ""2018-03-30T01:41:40Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-03-30T02:00:18Z"",
          ""endTime"" : ""2018-03-30T02:59:42Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 22,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 25,
              ""name"" : ""Dallas Stars"",
              ""link"" : ""/api/v1/teams/25""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-01T00:09:35Z"",
          ""endTime"" : ""2018-04-01T00:46:32Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-01T01:04:42Z"",
          ""endTime"" : ""2018-04-01T01:44:47Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-01T02:03:18Z"",
          ""endTime"" : ""2018-04-01T02:41:58Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 25,
              ""name"" : ""Dallas Stars"",
              ""link"" : ""/api/v1/teams/25""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 36,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 34,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-03T00:08:43Z"",
          ""endTime"" : ""2018-04-03T00:48:30Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-03T01:07:45Z"",
          ""endTime"" : ""2018-04-03T01:43:19Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-03T02:02:08Z"",
          ""endTime"" : ""2018-04-03T02:34:33Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 21,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 3,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 40,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 22,
              ""name"" : ""Edmonton Oilers"",
              ""link"" : ""/api/v1/teams/22""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 22,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-05T02:07:39Z"",
          ""endTime"" : ""2018-04-05T02:41:44Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-05T02:59:53Z"",
          ""endTime"" : ""2018-04-05T03:40:19Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-05T03:58:45Z"",
          ""endTime"" : ""2018-04-05T04:32:10Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 24,
              ""name"" : ""Anaheim Ducks"",
              ""link"" : ""/api/v1/teams/24""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 4,
        ""currentPeriodOrdinal"" : ""OT"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-06T02:38:49Z"",
          ""endTime"" : ""2018-04-06T03:16:18Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-06T03:34:10Z"",
          ""endTime"" : ""2018-04-06T04:15:10Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-06T04:32:57Z"",
          ""endTime"" : ""2018-04-06T05:16:02Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2018-04-06T05:17:54Z"",
          ""endTime"" : ""2018-04-06T05:19:13Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 0,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 26,
              ""name"" : ""Los Angeles Kings"",
              ""link"" : ""/api/v1/teams/26""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 27,
            ""goaliePulled"" : false,
            ""numSkaters"" : 3,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-08T02:39:50Z"",
          ""endTime"" : ""2018-04-08T03:13:41Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-08T03:31:55Z"",
          ""endTime"" : ""2018-04-08T04:07:26Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-08T04:25:37Z"",
          ""endTime"" : ""2018-04-08T05:02:15Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 18,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 28,
              ""name"" : ""San Jose Sharks"",
              ""link"" : ""/api/v1/teams/28""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 24,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-11T23:18:28Z"",
          ""endTime"" : ""2018-04-11T23:54:15Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-12T00:12:41Z"",
          ""endTime"" : ""2018-04-12T00:50:54Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-12T01:09:29Z"",
          ""endTime"" : ""2018-04-12T01:55:28Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 19,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 4,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 52,
              ""name"" : ""Winnipeg Jets"",
              ""link"" : ""/api/v1/teams/52""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 40,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 20,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-13T23:40:02Z"",
          ""endTime"" : ""2018-04-14T00:17:43Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-14T00:36:06Z"",
          ""endTime"" : ""2018-04-14T01:08:35Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-14T01:26:55Z"",
          ""endTime"" : ""2018-04-14T02:22:18Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 17,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 3,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 52,
              ""name"" : ""Winnipeg Jets"",
              ""link"" : ""/api/v1/teams/52""
            },
            ""goals"" : 4,
            ""shotsOnGoal"" : 44,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 1,
            ""shotsOnGoal"" : 17,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 0,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-15T23:10:54Z"",
          ""endTime"" : ""2018-04-15T23:56:03Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-16T00:15:01Z"",
          ""endTime"" : ""2018-04-16T00:55:17Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 4,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-16T01:14:03Z"",
          ""endTime"" : ""2018-04-16T01:49:40Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 6,
            ""shotsOnGoal"" : 29,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 52,
              ""name"" : ""Winnipeg Jets"",
              ""link"" : ""/api/v1/teams/52""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 385,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-18T00:11:01Z"",
          ""endTime"" : ""2018-04-18T00:43:46Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-18T01:02:18Z"",
          ""endTime"" : ""2018-04-18T01:40:22Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-18T01:58:57Z"",
          ""endTime"" : ""2018-04-18T02:35:16Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 52,
              ""name"" : ""Winnipeg Jets"",
              ""link"" : ""/api/v1/teams/52""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 28,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 11,
          ""inSituation"" : false
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
      ""linescore"" : {
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-20T23:40:24Z"",
          ""endTime"" : ""2018-04-21T00:18:15Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 4,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-21T00:37:03Z"",
          ""endTime"" : ""2018-04-21T01:10:57Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 7,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2018-04-21T01:29:27Z"",
          ""endTime"" : ""2018-04-21T02:04:29Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        } ],
        ""shootoutInfo"" : {
          ""away"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          },
          ""home"" : {
            ""scores"" : 0,
            ""attempts"" : 0
          }
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 52,
              ""name"" : ""Winnipeg Jets"",
              ""link"" : ""/api/v1/teams/52""
            },
            ""goals"" : 5,
            ""shotsOnGoal"" : 26,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 30,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          }
        },
        ""powerPlayStrength"" : ""Even"",
        ""hasShootout"" : false,
        ""intermissionInfo"" : {
          ""intermissionTimeRemaining"" : 0,
          ""intermissionTimeElapsed"" : 0,
          ""inIntermission"" : false
        },
        ""powerPlayInfo"" : {
          ""situationTimeRemaining"" : 0,
          ""situationTimeElapsed"" : 1168,
          ""inSituation"" : false
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
