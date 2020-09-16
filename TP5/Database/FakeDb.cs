using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP.Models;

namespace TP5.Database
{
    public class FakeDb
    {

        private static readonly Lazy<FakeDb> lazy =
           new Lazy<FakeDb>(() => new FakeDb());    
        public static FakeDb Instance { get { return lazy.Value; } }

        private FakeDb()
        {
            this.ListeChat = new List<Chat>();
            this.InitialiserDatas();
        }

        public List<Chat> ListeChat { get; private set; }

        private void InitialiserDatas()
        {
            var i = 1;

            ListeChat.Add(new Chat { Id = i++, Nom = "Felix", Age = 3, Couleur = "Roux" });
            ListeChat.Add(new Chat { Id = i++, Nom = "Minette", Age = 1, Couleur = "Noire" });
            ListeChat.Add(new Chat { Id = i++, Nom = "Miss", Age = 10, Couleur = "Blanche" });
            ListeChat.Add(new Chat { Id = i++, Nom = "Garfield", Age = 6, Couleur = "Gris" });
            ListeChat.Add(new Chat { Id = i++, Nom = "Chatran", Age = 4, Couleur = "Fauve" });
            ListeChat.Add(new Chat { Id = i++, Nom = "Minou", Age = 2, Couleur = "Blanc" });
            ListeChat.Add(new Chat { Id = i, Nom = "Bichette", Age = 12, Couleur = "Rousse" });
           
        }
    }
}