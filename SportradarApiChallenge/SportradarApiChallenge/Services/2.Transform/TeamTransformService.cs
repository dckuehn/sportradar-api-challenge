using SportradarApiChallenge.Models.Extract;
using SportradarApiChallenge.Models.Transform;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportradarApiChallenge.Services._2.Transform
{
    public class TeamTransformService
    {
        public TeamPipelineModel TransformTeamResult(Team team, List<Date> dates)
        {
            throw new NotImplementedException();
        }

        public int GetWins(int teamId, List<Date> dates, string gameTypes = "PR,R,P,A,WA,O,WCOH_EXH,WCOH_PRELIM,WCOH_FINAL")
        {
            List<string> gameTypeList = gameTypes.Split(",").ToList();
            int winCount = 0;

            dates.ForEach(d =>
            {
                d.games.ForEach(g =>
                {
                    if (gameTypeList.Contains(g.gameType))
                    {
                        if (g.teams.home.team.id == teamId && g.teams.home.score > g.teams.away.score)
                        {
                            winCount += 1;
                        }
                        else if (g.teams.away.team.id == teamId && g.teams.away.score > g.teams.home.score)
                        {
                            winCount += 1;
                        }
                    }
                });
            });

            return winCount;
        }

        public int GetLosses(int teamId, List<Date> dates)
        {
            throw new NotImplementedException();
        }

        public double GetPointsPerGame(int teamId, List<Date> dates)
        {
            throw new NotImplementedException();
        }

        public string GetFirstOpponentOfSeason(int teamId, List<Date> dates)
        {
            throw new NotImplementedException();
        }

        public DateTime GetFirstGameOfSeason(int teamId, List<Date> dates)
        {
            throw new NotImplementedException();
        }
    }
}