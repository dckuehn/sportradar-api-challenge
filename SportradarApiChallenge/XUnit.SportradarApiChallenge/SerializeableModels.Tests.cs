using SportradarApiChallenge.Models.Extract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Xunit;

namespace XUnit.SportradarApiChallenge
{
    public class SerializeableModels
    {
        [Fact]
        public void SampleTeam_ShouldSerialize_SingleTeam()
        {
            // Arrange and Act
            var rootTeamObject = JsonSerializer.Deserialize<RootTeamResponse>(SampleApiResponses.SampleTeamResponses.MinnesotaWild);

            // Assert
            Assert.Equal(1, rootTeamObject.teams.Count);

            Team minnesotaWild = rootTeamObject.teams[0];
            
            Assert.Equal(37, minnesotaWild.franchiseId);
            Assert.Equal("MIN", minnesotaWild.abbreviation);
        }

        [Fact]
        public void SingleSeason_ShouldSerialize_AsNinetyThreeDates()
        {
            // Arrange and Act
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);

            // Assert
            Assert.Equal(94, rootScheduleObject.dates.Count);
        }

        [Fact]
        public void SingleSeason_ShouldSerialize_Dates()
        {
            // Arrange and Act
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            Date firstDateObject = rootScheduleObject.dates.FirstOrDefault();

            // Assert
            Assert.Equal("2017-09-18", firstDateObject.date);
            Assert.Equal(1, firstDateObject.totalGames);
        }

        [Fact]
        public void SingleSeason_ShouldSerialize_GameOne()
        {
            // Arrange and Act
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            Date firstDateObject = rootScheduleObject.dates.FirstOrDefault();
            Game firstGameObject = firstDateObject.games.FirstOrDefault();

            // Assert
            Assert.Equal(2017010008, firstGameObject.gamePk);
            Assert.Equal(30, firstGameObject.teams.away.team.id);
            Assert.Equal(1, firstGameObject.teams.away.leagueRecord.wins);
        }
    }
}
