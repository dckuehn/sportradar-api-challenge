using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportradarApiChallenge.Models.Extract
{
    public class Linescore
    {
         public int currentPeriod { get; set; }
        public string currentPeriodOrdinal { get; set; }
        public string currentPeriodTimeRemaining { get; set; }
        public List<Period> periods { get; set; }
        //public ShootoutInfo shootoutInfo { get; set; }
        //public LinescoreTeam teams { get; set; }
        public bool hasShootout { get; set; }
        //public IntermissionInfo intermissionInfo { get; set; }
        //public PowerPlayInfo powerPlayINfo { get; set; }
    }
}
