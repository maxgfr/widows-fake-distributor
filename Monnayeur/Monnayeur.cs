using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    public class Monnayeur
    {
        private Caisse caisse;
        private Goulotte goulotte;
        private Validateur validateur;

        public Monnayeur ()
        {
            caisse = new Caisse(this);
            goulotte = new Goulotte(this);
            validateur = new Validateur(this,goulotte);
            
        }

        public void start(Client client)
        {
            bool valide;
            Pieces[] piece;
            piece=client.IntroduireSomme();
            valide = validateur.VerifTout(piece, client);
            if (valide) // si tout est normal on peut ranger les sous
            {
                validateur.RangerPiece(piece, caisse, client); // il me manque, il y a pas assez de sous et le rendage monnaie
            }
        }

        public void administration (Administrateur admin)
        {
            admin.EtatsTubes();
            admin.EtatsCaisse(caisse);
        }
    }
}
