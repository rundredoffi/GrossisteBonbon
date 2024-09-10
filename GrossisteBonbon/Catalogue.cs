using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossisteBonbon
{
    public class Catalogue
    {
        private List<Bonbon> lesBonbons;
        // constructeur à écrire
        public Catalogue()
        {
            lesBonbons.Add(new BonbonPoids(20, "bar25", "5 barres chocolatées", 5.5));
            lesBonbons.Add(new BonbonPoids(500, "bar33", "10 kinder", 5.6));
            lesBonbons.Add(new BonbonPoids(500, "bar33", "10 kinder", 5.6));
        }
        // ramène le bonbon dont l'id est passé en référence
        // ramène null si le bonbon n'existe pas
        public Bonbon RechercheBonbon(string idProduit)
        {
            return null;
        }
        // ajout Bonbon, vérification absence de doublon
        public Boolean AddBonbon(Bonbon b)
        {
            Console.WriteLine("Ajouter un bonbon au catalogue");
            Console.WriteLine("Nom du bonbon");
            string nom = Console.ReadLine();
            Console.WriteLine("Prix hors taxe : ");
            double prix = double.Parse(Console.ReadLine());
            Console.WriteLine("Identifiant du bonbon");
            string id = Console.ReadLine();
            Console.WriteLine("Poids du bonbon");
            float poids = float.Parse(Console.ReadLine());
            lesBonbons.Add(new BonbonPoids(poids, id, nom,prix));
            return false;
        }
        // ramène la liste des bonbons au poids
        public List<BonbonPoids> LesBonbonsAuPoids()
        {
            return null;

        }
    }

}
