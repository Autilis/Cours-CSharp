using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOgameV2
{
    public abstract class ResourceGenerator : Building
    {
        public List<Resource> ResourceBySecond = new List<Resource>();

    }
}
