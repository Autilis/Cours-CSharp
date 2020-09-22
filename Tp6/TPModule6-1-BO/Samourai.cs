using BO;
using System.Collections.Generic;

namespace TpModule6Bo
{
    public class Samourai : FacBo
    {
        //public int Id { get; set; }
        public int Force { get; set; }
        public string Nom { get; set; }
        public virtual Arme Arme { get; set; }
        public List<ArtMartial> ArtMartials { get; set; }
    }
}
