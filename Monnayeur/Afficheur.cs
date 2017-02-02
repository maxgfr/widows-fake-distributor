using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    public abstract class Afficheur
    {

        public static int Choisir ()
        {
            Console.WriteLine("Choisissez quelle pièce introduire :");
            Console.WriteLine("1 - 5 centimes");
            Console.WriteLine("2 - 10 centimes");
            Console.WriteLine("3 - 20 centimes");
            Console.WriteLine("4 - 50 centimes");
            Console.WriteLine("5 - 1 euro");
            Console.WriteLine("6 - 2 euros");
            Console.WriteLine("9 - pour un remboursement");
            return int.Parse(Console.ReadLine());
        }

        public static void EtatMachineTube (int nombre1, int nombre2, int nombre3, int nombre4, int nombre5, int nombre6)
        {
            Console.WriteLine("Il reste dans les tubes :");
            Console.WriteLine("{0} pieces de 5 centimes ", nombre1);
            Console.WriteLine("{0} pieces de 10 centimes ", nombre2);
            Console.WriteLine("{0} pieces de 20 centimes ", nombre3);
            Console.WriteLine("{0} pieces de 50 centimes", nombre4);
            Console.WriteLine("{0} pieces de 1 euro", nombre5);
            Console.WriteLine("{0} pieces de 2 euros", nombre6);
        }

        public static void EtatMachineCaisse (int nombre1, int nombre2, int nombre3, int nombre4, int nombre5, int nombre6, int nombre7)
        {
            Console.WriteLine("Il y a dans la caisse :");
            Console.WriteLine("{0} emplacement de pieces de 5 centimes ", nombre1);
            Console.WriteLine("{0} emplacement de pieces de 10 centimes ", nombre2);
            Console.WriteLine("{0} emplacement de pieces de 20 centimes ", nombre3);
            Console.WriteLine("{0} emplacement de pieces de 50 centimes", nombre4);
            Console.WriteLine("{0} emplacement de pieces de 1 euro", nombre5);
            Console.WriteLine("{0} emplacement de pieces de 2 euros", nombre6);
            Console.WriteLine("{0} emplacement de pieces au total", nombre7);
        }

        public static int RecevoirNombrePiece ( )
        {
            Console.WriteLine(" Combien de pièces voulez-vous insérer ? ");
            return  int.Parse(Console.ReadLine());
        }

        public static void RendreSous(int valeur)
        {
            Console.WriteLine(" Le disbruteur vous a rendu {0} centimes",valeur);
        }

        public static void RecevoirPasAssez()
        {
            Console.WriteLine("Le disbruteur vous a rendu tous vos centimes du faite que vous n'avez pas assez de monnaie pour payer le produit.");
        }


        public static void RecevoirPiece(Pieces p)
        {
            Console.WriteLine(" {0} euros ont été introduits.",p);
        }

        public static void MontantTot(int montant)
        {
            Console.WriteLine("Au total : {0} centimes ont été introduits.", montant);

        }

        public static void StockPiece ()
        {
            Console.WriteLine("Toutes les pièces ont été stockée");
        }


        public static void DonnerPiece (Pieces [] piece, int taille)
        {
            int cpt = 0;
            while (cpt<taille)
            {
                Console.WriteLine(" {0} euros a été rendus. ", piece[cpt]); //appelle to string de la piece rendue
                cpt++;
            }
            
        }

        public static void RecevoirPieceInconnu ()
        {
            Console.WriteLine(" La pièce est non reconnu, veuillez la récupérer");
        }

        public static void RecevoirTropSomme(int nombre)
        {
            Console.WriteLine("La somme insérée est trop importante,vous allez être rembourser de {0} centimes.", nombre);
        }

        public static void Remboursement()
        {
            Console.WriteLine("Le remboursement a eu lieu, Merci :).");
        }

    }
}
