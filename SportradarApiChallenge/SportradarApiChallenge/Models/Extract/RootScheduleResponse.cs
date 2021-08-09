using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportradarApiChallenge.Models.Extract
{
    public class RootScheduleResponse
    {
        public string copyright { get; set; }
        public int totalItems { get; set; }
        public int totalEvents { get; set; }
        public int totalGames { get; set; }
        public int totalMatches { get; set; }
        public Metadata metaData { get; set; }
        public int wait { get; set; }
        public List<Date> dates { get; set; }
    }
}
