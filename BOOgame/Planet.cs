using System;
using System.Collections.Generic;
using System.Text;

namespace BOOgame
{
    public class Planet : SolarSystem
    {

        
        public string name { get; set; }
        public int? caseNb { get; set; }

        public List<Resource> resources;

    }
}
