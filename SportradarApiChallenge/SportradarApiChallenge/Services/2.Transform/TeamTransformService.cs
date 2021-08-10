﻿using SportradarApiChallenge.Models.Extract;
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

        public int GetLosses(int teamId, List<Date> dates, string gameTypes = "PR,R,P,A,WA,O,WCOH_EXH,WCOH_PRELIM,WCOH_FINAL")
        {
            List<string> gameTypeList = gameTypes.Split(",").ToList();

            int lossCount = 0;
            int startingOvertimeLosses = -1;
            int finalOvertimeLosses = -1;

            dates.ForEach(d =>
            {
                d.games.ForEach(g =>
                {
                    if (gameTypeList.Contains(g.gameType))
                    {
                        if (g.teams.home.team.id == teamId && g.teams.home.score < g.teams.away.score)
                        {
                            lossCount += 1;
                        }
                        else if (g.teams.away.team.id == teamId && g.teams.away.score < g.teams.home.score)
                        {
                            lossCount += 1;
                        }
                        if (startingOvertimeLosses == -1)
                        {
                            // Set our starting OT value based on initail LeageRecord.OT value of our teamId record
                            startingOvertimeLosses = g.teams.home.team.id == teamId ? g.teams.home.leagueRecord.ot : g.teams.away.leagueRecord.ot;
                        }
                        // finalOvertimeLosses is reset every game (OT value only increases on actual OT losses so this is ok)
                        finalOvertimeLosses = g.teams.home.team.id == teamId ? g.teams.home.leagueRecord.ot : g.teams.away.leagueRecord.ot;
                    }
                });
            });

            // example: 3 totalOvertimeLosses equals 4 final overtime losses - 1 starting overtime loss
            int totalOTLosses = finalOvertimeLosses - startingOvertimeLosses;

            return lossCount - totalOTLosses;
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