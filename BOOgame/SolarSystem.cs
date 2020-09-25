using System;
using System.Collections.Generic;
using System.Text;

namespace BOOgame
{
    public class SolarSystem : IDbEntity
    {

        public string Name { get; set; }

        public List<Planet> planets;

    }
}
