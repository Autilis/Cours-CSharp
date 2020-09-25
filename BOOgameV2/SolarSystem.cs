using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOgameV2
{
    public class SolarSystem : IDbEntity
    {

        private long id;
        private string name;
        private List<Planet> planets = new List<Planet>();

        public virtual long Id { get => this.id; set => this.id = value; }

        [MinLength(5)]
        [MaxLength(20)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Planet> Planets
        {
            get { return planets; }
            set { planets = value; }
        }



    }
}
