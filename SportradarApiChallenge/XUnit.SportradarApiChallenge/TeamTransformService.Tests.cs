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
        public void GetPreSeasonWins_ShouldReturn_FourtyFiveWins()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            int teamId = 30;

            // Act
            int wins = teamTransformService.GetWins(teamId, rootScheduleObject.dates, "PR");

            // Assert
            Assert.Equal(5, wins);
        }

        [Fact]
        public void GetRegularSeasonWins_ShouldReturn_FourtyFiveWins()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            int teamId = 30;

            // Act
            int wins = teamTransformService.GetWins(teamId, rootScheduleObject.dates, "R");

            // Assert
            Assert.Equal(45, wins);
        }

        [Fact]
        public void GetPostSeasonWins_ShouldReturn_FourtyFiveWins()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            int teamId = 30;

            // Act
            int wins = teamTransformService.GetWins(teamId, rootScheduleObject.dates, "P");

            // Assert
            Assert.Equal(1, wins);
        }

        [Fact]
        public void GetWins_ShouldReturn_FourtyFiveWins()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            int teamId = 30;

            // Act
            int wins = teamTransformService.GetWins(teamId, rootScheduleObject.dates, "PR,R,P");

            // Assert
            Assert.Equal(51, wins);
        }

        [Fact]
        public void GetLosses_ShouldReturn_TwentySixLosses()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            int teamId = 30;

            // Act
            int losses = teamTransformService.GetLosses(teamId, rootScheduleObject.dates);

            // Assert
            Assert.Equal(26, losses);
        }

        [Fact]
        public void GetPointsPerGame_ShouldReturn_OnePointTwoSixPPG()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            double Wild2017PointsPerGame = 1.23;
            int teamId = 30;

            // Act
            double pointsPerGame = teamTransformService.GetPointsPerGame(teamId, rootScheduleObject.dates);

            // Assert
            Assert.Equal(Wild2017PointsPerGame, pointsPerGame);
        }
    }
}
