using SportradarApiChallenge.Models.Extract;
using System;
using System.Collections.Generic;
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
            // Arrange
            var rootTeamObject = JsonSerializer.Deserialize<RootTeamResponse>(SampleApiResponses.SampleTeamResponses.MinnesotaWild);

            // Assert
            Assert.Equal(1, rootTeamObject.teams.Count);
        }

        [Fact]
        public void SingleSeason_ShouldSerialize_AsNinetyThreeDates()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);

            // Assert
            Assert.Equal(94, rootScheduleObject.dates.Count);
        }
    }
}
