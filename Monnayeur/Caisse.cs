using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    public class Caisse
    {
        private Monnayeur m;
        public int[] Tab { get; private set; } 
        //Le tableau nous servira a détecté le nombre de differentes pièces dans la caisse

        public Caisse (Monnayeur m )
        {
            Tab = new int [6];
            this.m = m;
        }

        public void StockPiece (int colonne) //on réfléchit pièce par pièce
        {
            Tab[colonne] = Tab[colonne] + 1 ;
        }
        public void DestockPiece(int colonne)
        {
            Tab[colonne] = Tab[colonne] - 1;
        }

        public int CapacitePieceSpecifique (Pieces p)
        {
            int colonne;
            colonne=Conversion.ConverColonnes(p);
            return Tab[colonne];
        }

        public int CapaciteTotale ()
        {
            int capacite = 0;
            for (int i = 0; i < Tab.Length; i++)
            {
                capacite = Tab[i];
            }    
            return capacite;
        }
    }
}
