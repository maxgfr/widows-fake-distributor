using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    public class Goulotte
    {
        private Monnayeur m;

        public Goulotte (Monnayeur m )
        {
            this.m = m;
        }

        public void RendreUnePiece (Pieces piece, Client client)
        {
            piece.EnlevPiece(1);
        }

        public void RendrePiecesTrop( Client client,int valeurTot)
        {
            Pieces[] piecerendre = new Pieces [50]; // ne peut rendre que 50 pièce maximum (protection du distributeur)
            int remboursement;
            remboursement = valeurTot - client.PrixObjet;
            Afficheur.RecevoirTropSomme(remboursement);
            piecerendre = Conversion.ConverRemboursement(remboursement,piecerendre,50);
            client.PrendreMonnaie(piecerendre,50);
        }
        
        public void RendrePiecesRemboursement(Pieces[] piece, Client client)
        {
            client.PrendreMonnaie(piece,client.NbPiece);           
            Afficheur.RecevoirPasAssez();
        }

    }
}
