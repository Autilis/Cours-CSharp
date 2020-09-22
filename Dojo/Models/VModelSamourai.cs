using BODojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dojo.Models
{
    public class VModelSamourai
    {
        // obj samourai
        public Samourai Samourai{ get; set; }      
        // Id du samourai
        //public int SamouraiId { get; set; }

        //obj arme
        //public Arme Arme{ get; set; }
        // Liste des armes
        public List<Arme> ArmesList { get; set; } = new List<Arme>();
        // Id de l'arme
        public int? ArmeId { get; set; }

    }
}