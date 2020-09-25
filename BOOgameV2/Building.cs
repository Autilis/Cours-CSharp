using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOgameV2
{
    public abstract class Building : IDbEntity
    {
        private long id;
        private string name;
        private int? level;
        private int? cellNb;
        private List<Resource> totalCost = new List<Resource>();
        private List<Resource> nextCost = new List<Resource>();


        public virtual long Id { get => this.id; set => this.id = value; }

        [MinLength(5)]
        [MaxLength(20)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int? Level
        {
            get { return level; }
            set { level = value; }
        }

        public int? CellNb
        {
            get { return cellNb; }
            set { cellNb = value; }
        }

        public List<Resource> TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public List<Resource> NextCost
        {
            get { return nextCost; }
            set { nextCost = value; }
        }

    }
}
