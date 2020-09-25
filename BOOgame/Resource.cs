using System;
using System.Collections.Generic;
using System.Text;

namespace BOOgame
{
    public class Resource : Planet
    {

        public string name { get; set; }
        public int? lastQuantity { get; set; }
        public DateTime lastUpdate { get; set; }

    }
}
