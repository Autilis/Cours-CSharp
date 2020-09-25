using System;
using System.Collections.Generic;
using System.Text;

namespace BOOgame
{
    public abstract class Building : Planet
    {

        public string name { get; set; }
        public int? level { get; set; }

        private int? CellNb { get; set; }
        private List<Resource> TotalCost { get; set; }
        private List<Resource> NextCost { get; set; }

    }
}
