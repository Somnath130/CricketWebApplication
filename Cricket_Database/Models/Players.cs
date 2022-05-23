using System;
using System.Collections.Generic;

namespace Cricket_Database.Models
{
    public partial class Players
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int? Age { get; set; }
    }
}
