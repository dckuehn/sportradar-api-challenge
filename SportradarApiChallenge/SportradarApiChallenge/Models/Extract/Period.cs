using System;

namespace SportradarApiChallenge.Models.Extract
{
    public class Period
    {
        public string periodType { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int num { get; set; }
        //public PeriodTeam home { get; set; }
        //public PeriodTeam away { get; set; }
    }
}