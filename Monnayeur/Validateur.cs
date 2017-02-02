using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    public class Validateur
    {
        private Monnayeur monnayeur;
        private Goulotte goulotte;

        public Validateur (Monnayeur m, Goulotte g) //c'est le cerveau du distributeur
        {
            monnayeur = m;
            goulotte= g;
        }

        public int VerifUnePiece (Pieces piece, Client client) //retourne valeur numerique d'une piece + verifie qualité de la piece
        {
            int valeur = 0;
            try
            {
                valeur=Conversion.ConverPieces(piece);
            }
            catch (Exception)
            {
                Afficheur.RecevoirPieceInconnu();
                goulotte.RendreUnePiece(piece, client);
            }
            return valeur;
        }
        
        public bool VerifTout (Pieces [] piece, Client client) // verifie qui ne depasse pas le montant autorisé (5balles) auquel cas return ok
        {
            int cpt = 0, valeur1piece = 0, valeurtot =0;
            while (cpt<client.NbPiece)
            {
                valeur1piece = VerifUnePiece(piece[cpt], client);
                valeurtot = valeurtot + valeur1piece; 
                if (client.Remboursement == true) // si le client veux un remboursement 
                {
                    goulotte.RendrePiecesRemboursement(piece, client);
                    return false;
                }
                cpt++;
            }
            Afficheur.MontantTot(valeurtot);
            if (valeurtot < client.PrixObjet)  // lorsqu'il y a pas assez de sous insérés pour le prix, ça rend tout
            {
                goulotte.RendrePiecesRemboursement(piece, client);
                return false;
            }
            if (valeurtot > client.PrixObjet)  // lorsqu'il y a trop de sous insérés pour le prix
            {
                goulotte.RendrePiecesTrop(client,valeurtot);
                return true; // on va quand même ranger les pieces du client vu qu'on lui a donner des nouvelles pièces
            }
            Afficheur.RendreSous(0); // rend 0 euros au client si la valeur totale mise équivaut au prix de l'objet
            return true;
        }
        
        public void RangerPiece (Pieces[] piece, Caisse caisse, Client client)
        {
            int cpt=0, colonne;
            Conversion.ConverPieces(piece[cpt]);
            while (cpt<client.NbPiece)
            {
                if ( piece[cpt].GetPiece() == 0 ) { // si y'a plus de place dans la tube stock à la caisse
                    colonne= Conversion.ConverColonnes(piece[cpt]);
                    caisse.StockPiece(colonne);
                }
                piece[cpt].AjoutPiece(1);
                cpt++;
            }
            Afficheur.StockPiece();
        }
    }
}
