using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportradarApiChallenge.Models
{
    public class Venue
    {
        string name { get; set; }
        string link { get; set; }
        string city { get; set; }
        TimeZone timeZone { get; set; }
    }
}
