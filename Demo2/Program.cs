using Demo2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.Age = 10;
            p1.Nom = "gergergerger";
            p1.Prenom = "prepmoremrozermze";

            Console.WriteLine(p1);

            Personne p2 = new Personne { Age = 12, Nom = "gtrgherger", Prenom = "gergergser"};

            Console.WriteLine(p2);

            Personne p3 = new Personne("grgerger", "grgergre", 62);

            Console.WriteLine(p3);

            Console.ReadKey();
        }
    }
}
