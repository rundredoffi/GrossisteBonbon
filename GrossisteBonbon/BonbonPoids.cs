using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossisteBonbon
{
    public class BonbonPoids : Bonbon
    {
        private float poids;

        public BonbonPoids(float poids, string idProduit, string designation, double prixHorsTaxe) : base(idProduit, designation, prixHorsTaxe) // Dans la partie base, indiqué les éléments hérité de bonbon.
        {
            this.Poids = poids;
        }

        public float Poids { get => poids; set => poids = value; }

        public override string ToString()
        {
            return "Le poids est :" + Poids;
        }
    }
}