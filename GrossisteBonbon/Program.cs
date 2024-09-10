using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GrossisteBonbon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Liste des bonbons");
            List<Bonbon> ListeBonbons = new List<Bonbon>();
            ListeBonbons.Add(new BonbonPoids(500, "bar33", "10 kinder", 5.6));
            
            
            foreach (BonbonPoids Bonbon in ListeBonbons)
            {
                Console.WriteLine("///////////////////////////////");
                Console.WriteLine("Identifiant du bonbon : "+Bonbon.IdProduit);
                Console.WriteLine("Désignation du bonbon : "+Bonbon.Designation);
                Console.WriteLine("Prix du bonbon : "+Bonbon.PrixHorsTaxe+" euros");
                Console.WriteLine("Poids : " + Bonbon.Poids+" gr");
            }
            Console.ReadLine();

        }
    }
}
