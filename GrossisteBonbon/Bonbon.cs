using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossisteBonbon
{
    public class Bonbon
    {
        private string idProduit;
        private string designation;
        private double prixHorsTaxe;
        public Bonbon(string idProduit, string designation, double prixHorsTaxe)
        {
            this.idProduit = idProduit;
            this.designation = designation;
            this.prixHorsTaxe = prixHorsTaxe;
        }
        public string IdProduit {
            get => idProduit;
        }
        public string Designation { 
            get => designation;
        }
        public double PrixHorsTaxe {
            get => prixHorsTaxe; 
            set => prixHorsTaxe = value;
        }
        public override string ToString()
        {
            return "id: " + idProduit + " désignation:  " + designation + " prix HT: " + prixHorsTaxe;
        }
    }
}
