using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossisteBonbon
{
    public class BonbonPiece : Bonbon
    {
        private int piece;

        public BonbonPiece(int piece, string idProduit, string designation, double prixHorsTaxe) : base(idProduit, designation, prixHorsTaxe) // Dans la partie base, indiqué les éléments hérité de bonbon.
        {
            this.Piece   = piece;
        }

        public int Piece { get => piece; set => piece = value; }

        public override string ToString()
        {
            return "Le nombre de piece est :" + Piece;
        }
    }
}