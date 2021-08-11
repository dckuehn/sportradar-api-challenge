using SportradarApiChallenge.Models.Transform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SportradarApiChallenge.Services._3.Load
{
    public class TeamFileService
    {
        public byte[] CreateFileStrings(TeamPipelineModel tpm)
        {
            string headerLine = "TeamID,TeamName,TeamVenueName,GamesPlayed,Wins,Losses,Points,GoalsPerGame,FirstGameDate,FirstGameOpponent\n";
            byte[] headerBytes = System.Text.Encoding.UTF8.GetBytes(headerLine);

            string dataLine = $"{tpm.TeamID},{tpm.TeamName},{tpm.TeamVenueName},{tpm.GamesPlayed},{tpm.Wins},{tpm.Losses},{tpm.Points},{tpm.GoalsPerGame},{tpm.FirstGameDate},{tpm.FirstGameOpponentTeamName}\n";
            byte[] dataBytes = System.Text.Encoding.UTF8.GetBytes(dataLine);

            IEnumerable<byte> totalBytes = headerBytes.Concat(dataBytes);

            return totalBytes.ToArray();
        }
    }
}
