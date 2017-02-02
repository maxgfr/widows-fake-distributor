using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    public class Client
    {
        public String nom;
        public int SousFinale { get; private set; } // en centimes 
        public int NbPiece { get; private set; }
        public bool Remboursement { get; private set; }
        public int PrixObjet { get; private set; }

        public Client (String nom, int prix)
        {
            this.nom = nom;
            PrixObjet = prix;
            Remboursement = false;
        }

        public Pieces InsertionUnePiece ()
        {
            int choix;
            choix = Afficheur.Choisir();
           
            switch (choix)
            {
                case 1:
                    Console.WriteLine("Vous avez inséré une pièce de 5 centimes. ");
                    return new Cinqcentimes();
                case 2:
                    Console.WriteLine("Vous avez inséré une pièce de 10 centimes. ");
                    return new Dixcentimes();
                case 3:
                    Console.WriteLine("Vous avez inséré une pièce de 20 centimes. ");
                    return new Vingtcentimes();
                case 4:
                    Console.WriteLine("Vous avez inséré une pièce de 50 centimes. ");
                    return new Cinquantecentimes();
                case 5:
                    Console.WriteLine("Vous avez inséré une pièce de 1 euro. ");
                    return new Uneuro();
                case 6:
                    Console.WriteLine("Vous avez inséré une pièce de 2 euros. ");
                    return new Deuxeuro();
                case 9:
                    Console.WriteLine("Vous avez activer un remboursement de la somme introduite. ");
                    Remboursement = true;
                    return null;
                default:
                    throw new Exception(String.Format("Sélection invalide."));
            }
        }

        
        public Pieces [] IntroduireSomme ()
        {
            Pieces[] piece;
            int cpt = 0;

            NbPiece = Afficheur.RecevoirNombrePiece();
            Console.WriteLine("Vous souhaitez insérer {0} pièces", NbPiece);
            piece = new Pieces[NbPiece];

            while (cpt < NbPiece)
            { 
                piece [cpt] = InsertionUnePiece();
                if (Remboursement == true)
                {
                    return piece;
                }
                cpt++;
            }

            return piece;
        }


        public void PrendreMonnaie (Pieces[] piece, int taille ) // prend les sous qu'il a mis en trop OU reçoit remboursement
        {
            int cpt = 0, sous;
            Remboursement = false;
            NbPiece = piece.Count(s => s != null); // pour compter tous les éléments non null
            while (cpt<taille)
            {
                sous = Conversion.ConverPieces(piece[cpt]);
                SousFinale = sous + SousFinale;
                cpt++;
            }

            Console.WriteLine("TEST : Je suis  {0} j'ai recupéré {1} centimes et j'ai {2} pièces",nom, SousFinale, NbPiece);
        }
    }
}
