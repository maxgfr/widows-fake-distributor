using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    public abstract class Conversion
    {
        public static Pieces ConverNombre (int nombre) // le 0 correspond a un remboursement
        {
            if (nombre == 0) { return null; }
            if (nombre == 5) { return new Cinqcentimes(); }
            if (nombre == 10) { return new Dixcentimes(); }
            if (nombre == 20) { return new Vingtcentimes(); }
            if (nombre == 50) { return new Cinquantecentimes(); }
            if (nombre == 100) { return new Uneuro(); }
            if (nombre == 200) { return new Deuxeuro(); }
            else { throw new Exception("Pièce non reconnu. "); } // cas impossible c'est le travail du validateur
        }

        public static int ConverPieces (Pieces piece)
        {
            if (piece ==null) { return 0; }
            if (piece.Equals(new Cinqcentimes())) { return 5; }
            if (piece.Equals(new Dixcentimes())) { return 10; }
            if (piece.Equals(new Vingtcentimes())) { return 20; }
            if (piece.Equals(new Cinquantecentimes())) { return 50; }
            if (piece.Equals(new Uneuro())) { return 100; }
            if (piece.Equals(new Deuxeuro())) { return 200; }
            else { throw new Exception("Pièce non reconnu. "); } // cas impossible c'est le travail du validateur
        }

        public static int ConverColonnes (Pieces piece)
        {
            if (piece.Equals(new Cinqcentimes())) { return 0; }
            if (piece.Equals(new Dixcentimes())) { return 1; }
            if (piece.Equals(new Vingtcentimes())) { return 2; }
            if (piece.Equals(new Cinquantecentimes())) { return 3; }
            if (piece.Equals(new Uneuro())) { return 4; }
            if (piece.Equals(new Deuxeuro())) { return 5; }
            else { throw new Exception("Pièce non convertible en colonnes. "); } // cas impossible c'est le travail du validateur
        }

        public static Pieces[] ConverRemboursement (int valeurarendre, Pieces[] piece, int taille) //ALGO DE RENDU DE MONNAIE préviligiant de rendre d'abord les grosses pièces
        {
            int cpt = 0;
            while (valeurarendre !=0 && cpt<taille)
            {
                valeurarendre = valeurarendre - 200;
                piece[cpt] = new Deuxeuro();
                if (valeurarendre < 0)
                {
                    valeurarendre = valeurarendre - 100 + 200;
                    piece[cpt] = new Uneuro();
                    if (valeurarendre < 0)
                    {
                        valeurarendre = valeurarendre - 50 + 100;
                        piece[cpt] = new Cinquantecentimes();
                        if (valeurarendre < 0)
                        {
                            valeurarendre = valeurarendre - 20 + 50;
                            piece[cpt] = new Vingtcentimes();
                            if (valeurarendre < 0)
                            {
                                valeurarendre = valeurarendre - 10 + 20;
                                piece[cpt] = new Dixcentimes();
                                if (valeurarendre < 0)
                                {
                                    valeurarendre = valeurarendre - 5 + 10;
                                    piece[cpt] = new Cinqcentimes();
                                }
                            }
                        }
                    }
                }
               cpt++;
            }
            return piece;
        }
    }
}
