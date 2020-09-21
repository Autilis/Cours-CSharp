using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP1_Mod5.Database;

namespace TP1_Mod5.Models
{
    public class VModel
    {
        /*
        public List<Ingredient> Ingredients { get; set; } = FakeDb.Instance.IngredientsDisponibles;
        public List<Pate> Pates { get; set; } = FakeDb.Instance.PatesDisponibles;

        public Pizza Pizza { get; set; }
        public Ingredient Ingredient { get; set; }
        public int? IdPate { get; set; }
        */

        public Pizza Pizza { get; set; }
        public List<SelectListItem> Ingredients { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Pates { get; set; } = new List<SelectListItem>();

        [Required]
        public int? IdPate { get; set; }
        public List<int> IdsIngredients { get; set; } = new List<int>();
    }
}