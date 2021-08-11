using System;
using System.Collections.Generic;
using System.Text;

namespace XUnit.SportradarApiChallenge.SampleApiResponses
{
    public class ShortScheduleWithOvertime
    {
        public static string MinnesotaWildShortScheduleOvertime
        {
            get
            {
                return @"
{
  ""copyright"" : ""NHL and the NHL Shield are registered trademarks of the National Hockey League. NHL and NHL team marks are the property of the NHL and its teams. © NHL 2021. All Rights Reserved."",
  ""totalItems"" : 8,
  ""totalEvents"" : 0,
  ""totalGames"" : 8,
  ""totalMatches"" : 0,
  ""metaData"" : {
    ""timeStamp"" : ""20210811_180932""
  },
  ""wait"" : 10,
  ""dates"" : [ {
    ""date"" : ""2019-01-10"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2018020678,
      ""link"" : ""/api/v1/game/2018020678/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20182019"",
      ""gameDate"" : ""2019-01-11T01:00:00Z"",
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
            ""losses"" : 14,
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
            ""wins"" : 22,
            ""losses"" : 18,
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
        ""currentPeriod"" : 3,
        ""currentPeriodOrdinal"" : ""3rd"",
        ""currentPeriodTimeRemaining"" : ""Final"",
        ""periods"" : [ {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-11T01:10:23Z"",
          ""endTime"" : ""2019-01-11T01:43:58Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
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
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-11T02:02:28Z"",
          ""endTime"" : ""2019-01-11T02:39:16Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-11T02:57:56Z"",
          ""endTime"" : ""2019-01-11T03:35:36Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 0,
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
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 22,
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
        ""link"" : ""/api/v1/game/2018020678/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2019-01-12"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2018020693,
      ""link"" : ""/api/v1/game/2018020693/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20182019"",
      ""gameDate"" : ""2019-01-13T01:00:00Z"",
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
            ""losses"" : 23,
            ""ot"" : 7,
            ""type"" : ""league""
          },
          ""score"" : 5,
          ""team"" : {
            ""id"" : 17,
            ""name"" : ""Detroit Red Wings"",
            ""link"" : ""/api/v1/teams/17""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 22,
            ""losses"" : 19,
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
          ""startTime"" : ""2019-01-13T01:08:38Z"",
          ""endTime"" : ""2019-01-13T01:47:13Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-13T02:05:59Z"",
          ""endTime"" : ""2019-01-13T02:42:56Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 21,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-13T03:01:35Z"",
          ""endTime"" : ""2019-01-13T03:36:59Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
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
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 18,
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
            ""goals"" : 5,
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
          ""situationTimeElapsed"" : 211,
          ""inSituation"" : false
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2018020693/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2019-01-14"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2018020708,
      ""link"" : ""/api/v1/game/2018020708/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20182019"",
      ""gameDate"" : ""2019-01-15T00:00:00Z"",
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
            ""losses"" : 20,
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
            ""wins"" : 17,
            ""losses"" : 23,
            ""ot"" : 6,
            ""type"" : ""league""
          },
          ""score"" : 7,
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
          ""startTime"" : ""2019-01-15T00:08:22Z"",
          ""endTime"" : ""2019-01-15T00:52:26Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-15T01:10:40Z"",
          ""endTime"" : ""2019-01-15T01:50:31Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-15T02:08:46Z"",
          ""endTime"" : ""2019-01-15T02:50:43Z"",
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
              ""id"" : 4,
              ""name"" : ""Philadelphia Flyers"",
              ""link"" : ""/api/v1/teams/4""
            },
            ""goals"" : 7,
            ""shotsOnGoal"" : 27,
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
          ""situationTimeElapsed"" : 53,
          ""inSituation"" : false
        }
      },
      ""venue"" : {
        ""id"" : 5096,
        ""name"" : ""Wells Fargo Center"",
        ""link"" : ""/api/v1/venues/5096""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2018020708/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2019-01-15"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2018020717,
      ""link"" : ""/api/v1/game/2018020717/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20182019"",
      ""gameDate"" : ""2019-01-16T01:00:00Z"",
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
            ""losses"" : 25,
            ""ot"" : 4,
            ""type"" : ""league""
          },
          ""score"" : 2,
          ""team"" : {
            ""id"" : 26,
            ""name"" : ""Los Angeles Kings"",
            ""link"" : ""/api/v1/teams/26""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 23,
            ""losses"" : 20,
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
          ""startTime"" : ""2019-01-16T01:10:37Z"",
          ""endTime"" : ""2019-01-16T01:44:35Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-16T02:04:27Z"",
          ""endTime"" : ""2019-01-16T02:43:29Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 14,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-16T03:02:22Z"",
          ""endTime"" : ""2019-01-16T03:38:45Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 9,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""OVERTIME"",
          ""startTime"" : ""2019-01-16T03:41:01Z"",
          ""endTime"" : ""2019-01-16T03:50:27Z"",
          ""num"" : 4,
          ""ordinalNum"" : ""OT"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
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
            ""scores"" : 0,
            ""attempts"" : 3
          },
          ""home"" : {
            ""scores"" : 1,
            ""attempts"" : 3
          },
          ""startTime"" : ""2019-01-16T03:52:11Z""
        },
        ""teams"" : {
          ""home"" : {
            ""team"" : {
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 3,
            ""shotsOnGoal"" : 42,
            ""goaliePulled"" : false,
            ""numSkaters"" : 0,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 26,
              ""name"" : ""Los Angeles Kings"",
              ""link"" : ""/api/v1/teams/26""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 33,
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
        ""link"" : ""/api/v1/game/2018020717/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2019-01-17"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2018020731,
      ""link"" : ""/api/v1/game/2018020731/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20182019"",
      ""gameDate"" : ""2019-01-18T01:00:00Z"",
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
            ""losses"" : 19,
            ""ot"" : 9,
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
            ""wins"" : 23,
            ""losses"" : 21,
            ""ot"" : 3,
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
          ""startTime"" : ""2019-01-18T01:08:28Z"",
          ""endTime"" : ""2019-01-18T01:44:09Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 10,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 3,
            ""shotsOnGoal"" : 13,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-18T02:02:50Z"",
          ""endTime"" : ""2019-01-18T02:37:32Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 2,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-18T02:56:11Z"",
          ""endTime"" : ""2019-01-18T03:32:59Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 15,
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
              ""id"" : 30,
              ""name"" : ""Minnesota Wild"",
              ""link"" : ""/api/v1/teams/30""
            },
            ""goals"" : 0,
            ""shotsOnGoal"" : 37,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 24,
              ""name"" : ""Anaheim Ducks"",
              ""link"" : ""/api/v1/teams/24""
            },
            ""goals"" : 3,
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
          ""situationTimeElapsed"" : 513,
          ""inSituation"" : false
        }
      },
      ""venue"" : {
        ""id"" : 5098,
        ""name"" : ""Xcel Energy Center"",
        ""link"" : ""/api/v1/venues/5098""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2018020731/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2019-01-19"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2018020748,
      ""link"" : ""/api/v1/game/2018020748/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20182019"",
      ""gameDate"" : ""2019-01-20T02:00:00Z"",
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
            ""losses"" : 17,
            ""ot"" : 3,
            ""type"" : ""league""
          },
          ""score"" : 1,
          ""team"" : {
            ""id"" : 29,
            ""name"" : ""Columbus Blue Jackets"",
            ""link"" : ""/api/v1/teams/29""
          }
        },
        ""home"" : {
          ""leagueRecord"" : {
            ""wins"" : 24,
            ""losses"" : 21,
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
          ""startTime"" : ""2019-01-20T02:08:28Z"",
          ""endTime"" : ""2019-01-20T02:43:57Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-20T03:02:39Z"",
          ""endTime"" : ""2019-01-20T03:41:17Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 15,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-20T04:00:05Z"",
          ""endTime"" : ""2019-01-20T04:35:10Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 4,
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
            ""goals"" : 2,
            ""shotsOnGoal"" : 31,
            ""goaliePulled"" : false,
            ""numSkaters"" : 5,
            ""powerPlay"" : false
          },
          ""away"" : {
            ""team"" : {
              ""id"" : 29,
              ""name"" : ""Columbus Blue Jackets"",
              ""link"" : ""/api/v1/teams/29""
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
        ""link"" : ""/api/v1/game/2018020748/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2019-01-21"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2018020757,
      ""link"" : ""/api/v1/game/2018020757/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20182019"",
      ""gameDate"" : ""2019-01-21T23:00:00Z"",
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
            ""wins"" : 25,
            ""losses"" : 21,
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
            ""wins"" : 29,
            ""losses"" : 18,
            ""ot"" : 4,
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
          ""startTime"" : ""2019-01-21T23:09:31Z"",
          ""endTime"" : ""2019-01-21T23:49:29Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 5
          },
          ""away"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-22T00:08:01Z"",
          ""endTime"" : ""2019-01-22T00:58:04Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 1,
            ""shotsOnGoal"" : 19
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 8
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-22T01:07:59Z"",
          ""endTime"" : ""2019-01-22T01:49:06Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 8
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 8
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
            ""goals"" : 4,
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
          ""situationTimeElapsed"" : 13,
          ""inSituation"" : false
        }
      },
      ""venue"" : {
        ""id"" : 5178,
        ""name"" : ""T-Mobile Arena"",
        ""link"" : ""/api/v1/venues/5178""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2018020757/content""
      }
    } ],
    ""events"" : [ ],
    ""matches"" : [ ]
  }, {
    ""date"" : ""2019-01-23"",
    ""totalItems"" : 1,
    ""totalEvents"" : 0,
    ""totalGames"" : 1,
    ""totalMatches"" : 0,
    ""games"" : [ {
      ""gamePk"" : 2018020767,
      ""link"" : ""/api/v1/game/2018020767/feed/live"",
      ""gameType"" : ""R"",
      ""season"" : ""20182019"",
      ""gameDate"" : ""2019-01-24T02:30:00Z"",
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
            ""losses"" : 21,
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
            ""wins"" : 22,
            ""losses"" : 20,
            ""ot"" : 8,
            ""type"" : ""league""
          },
          ""score"" : 2,
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
          ""startTime"" : ""2019-01-24T02:40:31Z"",
          ""endTime"" : ""2019-01-24T03:19:29Z"",
          ""num"" : 1,
          ""ordinalNum"" : ""1st"",
          ""home"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 11,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 12,
            ""rinkSide"" : ""left""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-24T03:37:42Z"",
          ""endTime"" : ""2019-01-24T04:17:12Z"",
          ""num"" : 2,
          ""ordinalNum"" : ""2nd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 6,
            ""rinkSide"" : ""left""
          },
          ""away"" : {
            ""goals"" : 2,
            ""shotsOnGoal"" : 8,
            ""rinkSide"" : ""right""
          }
        }, {
          ""periodType"" : ""REGULAR"",
          ""startTime"" : ""2019-01-24T04:35:04Z"",
          ""endTime"" : ""2019-01-24T05:14:53Z"",
          ""num"" : 3,
          ""ordinalNum"" : ""3rd"",
          ""home"" : {
            ""goals"" : 0,
            ""shotsOnGoal"" : 5,
            ""rinkSide"" : ""right""
          },
          ""away"" : {
            ""goals"" : 1,
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
              ""id"" : 21,
              ""name"" : ""Colorado Avalanche"",
              ""link"" : ""/api/v1/teams/21""
            },
            ""goals"" : 2,
            ""shotsOnGoal"" : 22,
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
          ""situationTimeElapsed"" : 630,
          ""inSituation"" : false
        }
      },
      ""venue"" : {
        ""name"" : ""Pepsi Center"",
        ""link"" : ""/api/v1/venues/null""
      },
      ""content"" : {
        ""link"" : ""/api/v1/game/2018020767/content""
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
