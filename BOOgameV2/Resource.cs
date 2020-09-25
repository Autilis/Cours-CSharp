using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOgameV2
{
    public class Resource : IDbEntity
    {
        private long id;
        private string name;
        private int? lastQuantity;
        private DateTime lastUpdate;

        public virtual long Id { get => this.id; set => this.id = value; }

        [MinLength(5)]
        [MaxLength(20)]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int? LastQuantity
        {
            get { return lastQuantity; }
            set { lastQuantity = value; }
        }

        public DateTime LastUpdate
        {
            get { return lastUpdate; }
            set { lastUpdate = value; }
        }



    }
}
