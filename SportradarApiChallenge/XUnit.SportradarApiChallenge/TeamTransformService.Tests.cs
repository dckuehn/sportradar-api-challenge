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
        public void GetWins_ShouldReturn_FourtyFiveWins()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);

            // Act
            int wins = teamTransformService.GetWins(rootScheduleObject.dates);

            // Assert
            Assert.Equal(45, wins);
        }

        [Fact]
        public void GetLosses_ShouldReturn_TwentySixLosses()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);

            // Act
            int losses = teamTransformService.GetLosses(rootScheduleObject.dates);

            // Assert
            Assert.Equal(26, losses);
        }

        [Fact]
        public void GetPointsPerGame_ShouldReturn_OnePointTwoSixPPG()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            double Wild2017PointsPerGame = 1.23;

            // Act
            double pointsPerGame = teamTransformService.GetPointsPerGame(rootScheduleObject.dates);

            // Assert
            Assert.Equal(Wild2017PointsPerGame, pointsPerGame);
        }
    }
}
