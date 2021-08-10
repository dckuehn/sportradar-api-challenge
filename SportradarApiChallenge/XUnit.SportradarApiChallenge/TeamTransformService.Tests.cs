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
            int losses = teamTransformService.GetLosses(teamId, rootScheduleObject.dates, "R");

            // Assert
            Assert.Equal(26, losses);
        }


        [Fact]
        public void GetRegularSeasonGoalsPerGame_ShouldReturn_OnePointTwoSixPPG()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            int wildTeamId = 30;
            int Wild2017TotalGoalsFor = 253;
            int Wild2017TotalGamesPlayed = 82;

            double Wild2017GoalsPerGame = (double) Wild2017TotalGoalsFor / (double) Wild2017TotalGamesPlayed;

            // Act
            double pointsPerGame = teamTransformService.GetPointsPerGame(wildTeamId, rootScheduleObject.dates, "R");

            // Assert
            Assert.Equal(Wild2017GoalsPerGame, pointsPerGame);
        }

        [Fact]
        public void GetRegularSeasonFirstOpponent_ShouldReturn_DetroidRedWings()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            int wildTeamId = 30;

                // Act
            string firstRegularseasonOpponent = teamTransformService.GetFirstOpponentOfSeason(wildTeamId, rootScheduleObject.dates, "R");

            // Assert
            Assert.Equal("Detroit Red Wings", firstRegularseasonOpponent);
        }

        [Fact]
        public void GetPreSeasonFirstOpponent_ShouldReturn_WinnipegJets()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            int wildTeamId = 30;

            // Act
            string firstRegularseasonOpponent = teamTransformService.GetFirstOpponentOfSeason(wildTeamId, rootScheduleObject.dates, "PR");

            // Assert
            Assert.Equal("Winnipeg Jets", firstRegularseasonOpponent); //2017-09-18
        }

        [Fact]
        public void GetPreSeasonFirstGameDate_ShouldReturn_20170918()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            int wildTeamId = 30;

            // Act
            string firstGameDate = teamTransformService.GetFirstGameOfSeason(wildTeamId, rootScheduleObject.dates, "PR");

            // Assert
            Assert.Equal("2017-09-18", firstGameDate);
        }

        [Fact]
        public void GetPreSeasonFirstGameDate_ShouldReturn_20171005()
        {
            // Arrange
            var rootScheduleObject = JsonSerializer.Deserialize<RootScheduleResponse>(SampleApiResponses.SampleScheduleResponses.MinnesotaWild_20172018);
            int wildTeamId = 30;

            // Act
            string firstGameDate = teamTransformService.GetFirstGameOfSeason(wildTeamId, rootScheduleObject.dates, "R");

            // Assert
            Assert.Equal("2017-10-05", firstGameDate);
        }
    }
}
