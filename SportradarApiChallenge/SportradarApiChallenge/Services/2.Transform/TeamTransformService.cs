using SportradarApiChallenge.Models.Extract;
using SportradarApiChallenge.Models.Transform;
using System;
using System.Collections.Generic;

namespace SportradarApiChallenge.Services._2.Transform
{
    public class TeamTransformService
    {
        public TeamPipelineModel TransformTeamResult(Team team, List<Date> dates)
        {
            throw new NotImplementedException();
        }

        public int GetWins(int teamId, List<Date> dates)
        {
            throw new NotImplementedException();
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