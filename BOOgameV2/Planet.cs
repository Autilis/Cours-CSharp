using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOgameV2
{
    public class Planet : IDbEntity
    {
        private long id;
        private string name;
        private int? caseNb;
        private List<Resource> resources = new List<Resource>();
        private List<Building> buildings = new List<Building>();

        public virtual long Id { get => this.id; set => this.id = value; }

        [MinLength(5)]
        [MaxLength(20)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int? CaseNb
        {
            get { return caseNb; }
            set { caseNb = value; }
        }

        public List<Resource> Resources
        {
            get { return resources; }
            set { resources = value; }
        }


        [NotMapped]
        public List<Building> Buildings
        {
            get { return buildings; }
            set { buildings = value; }
        }

    }
}
