using SportradarApiChallenge.Models.Extract;
using SportradarApiChallenge.Models.Transform;
using SportradarApiChallenge.Services._2.Transform;
using System.Text.Json;
using Xunit;

namespace XUnit.SportradarApiChallenge
{
    public class TeamTransformServiceTests
    {

        TeamTransformService teamTransformService = new TeamTransformService();

        [Fact]
        public void TransformTeamResult_ShouldReturn_TeamPipelineModel()
        {
            // Arrange
            var rootTeamObject = JsonSerializer.Deserialize<RootTeamResponse>(SampleApiResponses.SampleTeamResponses.MinnesotaWild);
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);

            // Act
            var teamExtractResult = teamTransformService.TransformTeamResult(rootTeamObject.teams[0], rootScheduleObject.dates);

            // Assert
            Assert.IsType(typeof(TeamPipelineModel), teamExtractResult);
        }

        [Fact]
        public void TransformTeamResult_ShouldReturn_()
        {
            // Arrange
            var rootTeamObject = JsonSerializer.Deserialize<RootTeamResponse>(SampleApiResponses.SampleTeamResponses.MinnesotaWild);
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);

            // Act
            var teamExtractResult = teamTransformService.TransformTeamResult(rootTeamObject.teams[0], rootScheduleObject.dates);

            // Assert
            Assert.Equal(teamExtractResult.TeamName, "");
        }
    }
}
