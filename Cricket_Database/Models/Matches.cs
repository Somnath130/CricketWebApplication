using System;
using System.Collections.Generic;

namespace Cricket_Database.Models
{
    public partial class Matches
    {
        public int MatchId { get; set; }
        public int StadiumId { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public string Result { get; set; }
        public DateTime? DateTime { get; set; }
        public string WasMatchPlayed { get; set; }

        public Matches Match { get; set; }
        public Matches InverseMatch { get; set; }
    }
}
