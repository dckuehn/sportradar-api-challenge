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
            TeamPipelineModel teamPipeline = new TeamPipelineModel();

            teamPipeline.TeamID = team.id;
            teamPipeline.TeamName = team.name;
            teamPipeline.TeamVenueName = team.venue.name;
            teamPipeline.GamesPlayed = GetGames(team.id, dates);
            teamPipeline.Wins = GetWins(team.id, dates);
            teamPipeline.Losses = GetLosses(team.id, dates);
            teamPipeline.GoalsPerGame = GetPointsPerGame(team.id, dates);
            teamPipeline.FirstGameDate = GetFirstGameOfSeason(team.id, dates);
            teamPipeline.FirstGameOpponentTeamName = GetFirstOpponentOfSeason(team.id, dates);

            return teamPipeline;
        }

        public int GetGames(int teamId, List<Date> dates, string gameTypes = "PR,R,P,A,WA,O,WCOH_EXH,WCOH_PRELIM,WCOH_FINAL")
        {
            List<string> gameTypeList = gameTypes.Split(",").ToList();
            int gameCount = 0;

            dates.ForEach(d =>
            {
                d.games.ForEach(g =>
                {
                    if (gameTypeList.Contains(g.gameType))
                    {
                        if (g.teams.home.team.id == teamId)
                        {
                            gameCount += 1;
                        }
                        else if (g.teams.away.team.id == teamId)
                        {
                            gameCount += 1;
                        }
                    }
                });
            });

            return gameCount;
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

        public double GetGoalsPerGame(int teamId, List<Date> dates, string gameTypes = "PR,R,P,A,WA,O,WCOH_EXH,WCOH_PRELIM,WCOH_FINAL")
        {
            List<string> gameTypeList = gameTypes.Split(",").ToList();

            int totalGoals = 0;
            int totalGames = 0;

            dates.ForEach(d =>
            {
                d.games.ForEach(g =>
                {
                    if (gameTypeList.Contains(g.gameType))
                    {
                        if (g.teams.home.team.id == teamId)
                        {
                            totalGoals += g.teams.home.score;
                            totalGames += 1;
                        }
                        else if (g.teams.away.team.id == teamId)
                        {
                            totalGoals += g.teams.away.score;
                            totalGames += 1;
                        }
                    }
                });
            });
            
            return (double) totalGoals / (double) totalGames;
        }

        public int GetTotalPoints(int teamId, List<Date> dates, string gameTypes = "PR,R,P,A,WA,O,WCOH_EXH,WCOH_PRELIM,WCOH_FINAL")
        {
            List<string> gameTypeList = gameTypes.Split(",").ToList();

            int totalWins = 0;
            int startingOvertimeLosses = -1;
            int finalOvertimeLosses = -1;

            foreach (Date d in dates)
            {
                foreach (Game g in d.games)
                {
                    if (gameTypeList.Contains(g.gameType))
                    {
                        if (g.teams.home.team.id == teamId && g.teams.home.score > g.teams.away.score)
                        {
                            totalWins += 1;
                        }
                        else if (g.teams.away.team.id == teamId && g.teams.away.score > g.teams.home.score)
                        {
                            totalWins += 1;
                        }
                        if (startingOvertimeLosses == -1)
                        {
                            // Set our starting OT value based on initail LeageRecord.OT value of our teamId record
                            startingOvertimeLosses = g.teams.home.team.id == teamId ? g.teams.home.leagueRecord.ot : g.teams.away.leagueRecord.ot;
                        }
                        // finalOvertimeLosses is reset every game (OT value only increases on actual OT losses so this is ok)
                        finalOvertimeLosses = g.teams.home.team.id == teamId ? g.teams.home.leagueRecord.ot : g.teams.away.leagueRecord.ot;
                    }
                }
            }

            return totalWins * 2 + (finalOvertimeLosses - startingOvertimeLosses);
        }

        public string GetFirstOpponentOfSeason(int teamId, List<Date> dates, string gameTypes = "PR,R,P,A,WA,O,WCOH_EXH,WCOH_PRELIM,WCOH_FINAL")
        {
            List<string> gameTypeList = gameTypes.Split(",").ToList();

            dates = dates.OrderBy(d => DateTime.Parse(d.date)).ToList();

            foreach(Date d in dates)
            {
                foreach (Game g in d.games)
                {
                    if (gameTypeList.Contains(g.gameType))
                    {
                        if (g.teams.away.team.id == teamId)
                        {
                            return g.teams.home.team.name;
                            
                        }
                        else if (g.teams.home.team.id == teamId)
                        {
                            return g.teams.away.team.name;
                        }
                    }
                }
            }

            // Game of provided types not found within provided range
            return "";
        }

        public string GetFirstGameOfSeason(int teamId, List<Date> dates, string gameTypes = "PR,R,P,A,WA,O,WCOH_EXH,WCOH_PRELIM,WCOH_FINAL")
        {
            List<string> gameTypeList = gameTypes.Split(",").ToList();

            dates = dates.OrderBy(d => DateTime.Parse(d.date)).ToList();

            foreach (Date d in dates)
            {
                foreach (Game g in d.games)
                {
                    if (gameTypeList.Contains(g.gameType))
                    {
                        if (g.teams.away.team.id == teamId || g.teams.home.team.id == teamId)
                        {
                            return d.date;
                        }
                    }
                }
            }

            // Game of provided types not found within provided range
            return "";
        }
    }
}