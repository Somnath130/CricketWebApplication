using System;
using System.Collections.Generic;

namespace Cricket_Database.Models
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Continent { get; set; }
        public string Code { get; set; }
    }
}
