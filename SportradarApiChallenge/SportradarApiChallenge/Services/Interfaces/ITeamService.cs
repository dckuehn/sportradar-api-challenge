using System.Collections.Generic;

namespace SportradarApiChallenge.Services.Interfaces
{
    public interface ITeamService
    {
        byte[] SingleTeamSeasonPipeline(int teamId, int year);
    }
}
