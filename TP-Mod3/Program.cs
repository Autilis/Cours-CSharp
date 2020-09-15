using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Mod3.BO;

namespace TP_Mod3
{
    public class Program
    {

        private static List<Auteur> ListeAuteurs = new List<Auteur>();
        private static List<Livre> ListeLivres = new List<Livre>();

        private static void InitialiserDatas()
        {
            ListeAuteurs.Add(new Auteur("GROUSSARD", "Thierry"));
            ListeAuteurs.Add(new Auteur("GABILLAUD", "Jérôme"));
            ListeAuteurs.Add(new Auteur("HUGON", "Jérôme"));
            ListeAuteurs.Add(new Auteur("ALESSANDRI", "Olivier"));
            ListeAuteurs.Add(new Auteur("de QUAJOUX", "Benoit"));
            ListeLivres.Add(new Livre(1, "C# 4", "Les fondamentaux du langage", ListeAuteurs.ElementAt(0), 533));
            ListeLivres.Add(new Livre(2, "VB.NET", "Les fondamentaux du langage", ListeAuteurs.ElementAt(0), 539));
            ListeLivres.Add(new Livre(3, "SQL Server 2008", "SQL, Transact SQL", ListeAuteurs.ElementAt(1), 311));
            ListeLivres.Add(new Livre(4, "ASP.NET 4.0 et C#", "Sous visual studio 2010", ListeAuteurs.ElementAt(3), 544));
            ListeLivres.Add(new Livre(5, "C# 4", "Développez des applications windows avec visual studio 2010", ListeAuteurs.ElementAt(2), 452));
            ListeLivres.Add(new Livre(6, "Java 7", "les fondamentaux du langage", ListeAuteurs.ElementAt(0), 416));
            ListeLivres.Add(new Livre(7, "SQL et Algèbre relationnelle", "Notions de base", ListeAuteurs.ElementAt(1), 216));
            ListeAuteurs.ElementAt(0).addFacture(new Facture(3500, ListeAuteurs.ElementAt(0)));
            ListeAuteurs.ElementAt(0).addFacture(new Facture(3200, ListeAuteurs.ElementAt(0)));
            ListeAuteurs.ElementAt(1).addFacture(new Facture(4000, ListeAuteurs.ElementAt(1)));
            ListeAuteurs.ElementAt(2).addFacture(new Facture(4200, ListeAuteurs.ElementAt(2)));
            ListeAuteurs.ElementAt(3).addFacture(new Facture(3700, ListeAuteurs.ElementAt(3)));
        }
        static void Main(string[] args)
        {
            InitialiserDatas();

            //◦ Afficher la liste des prénoms des auteurs dont le nom commence par "G"
            var t1 = ListeAuteurs.Where(p => p.Nom.StartsWith("G"));
            foreach (var item in t1)
            {
                Console.WriteLine("Prenom : " + item.Prenom);
                //Console.WriteLine("Nom : " + item.Nom);
            }

            //◦ Afficher l’auteur ayant écrit le plus de livres
            var t2 = ListeLivres.GroupBy(a => a.Auteur).OrderByDescending(c => c.Count()).First().Key.Nom;
            Console.WriteLine("Auteur : " + t2);

            //◦ Afficher le nombre moyen de pages par livre par auteur
            //var t3 = ListeLivres.Select(a => a.Titre);
            //foreach (var item in t3.Average(a => a.NbPages))
            //{
            //    Console.WriteLine("Moyenne nb pages : " + item);
            //}

            //◦ Afficher le titre du livre avec le plus de pages
            var t4 = ListeLivres.OrderBy(x => x.NbPages).First().Titre;
            Console.WriteLine("Titre : " + t4);

            //◦ Afficher combien ont gagné les auteurs en moyenne(moyenne des factures)
            //var t5 = ListeAuteurs.Select(x => x.Factures);
            //Console.WriteLine("Moyenne des factures : " + t5.ToString);
            //var avgFact = ListeAuteurs.Average(a => a.Factures);
            //Console.WriteLine("avgFact : " + avgFact);

            //◦ Afficher les auteurs et la liste de leurs livres
            //◦ Afficher les titres de tous les livres triés par ordre alphabétique
            var t7 = ListeLivres.OrderBy(x => x.Titre);
            foreach (var item in t7)
            {
                Console.WriteLine("Titre livre : " + item.Titre);
            }

            //◦ Afficher la liste des livres dont le nombre de pages est supérieur à la moyenne
            var avg = ListeLivres.Average(a => a.NbPages);
            Console.WriteLine("avg : " + avg);

            var t8 = ListeLivres.Where(p => p.NbPages > avg);
            foreach (var item in t8)
            {
                Console.WriteLine("Liste de livre sup à la moyenne : " + item.Titre);
            }

            //◦ Afficher l'auteur ayant écrit le moins de livres
            var t9 = ListeLivres.GroupBy(a => a.Auteur).OrderBy(a => a.Count()).First();
            Console.WriteLine("L'auteur avec le moins de livre : " + t9.Key.Nom);

            Console.ReadKey();
        }

    }
}
