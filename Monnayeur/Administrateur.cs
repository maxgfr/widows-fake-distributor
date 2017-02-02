using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    public class Administrateur
    {

        public void EtatsTubes()
        {
            int nombre1, nombre2, nombre3, nombre4, nombre5, nombre6;
            nombre1 = new Cinqcentimes().GetPiece();
            nombre2 = new Dixcentimes().GetPiece();
            nombre3 = new Vingtcentimes().GetPiece();
            nombre4 = new Cinquantecentimes().GetPiece();
            nombre5 = new Uneuro().GetPiece();
            nombre6 = new Deuxeuro().GetPiece();
            Afficheur.EtatMachineTube(nombre1, nombre2, nombre3, nombre4, nombre5, nombre6);
        }


            public void EtatsCaisse (Caisse caisse)
        {
            int nombre1, nombre2, nombre3, nombre4, nombre5, nombre6, nombre7;
            nombre1 = caisse.CapacitePieceSpecifique(new Cinqcentimes());
            nombre2 = caisse.CapacitePieceSpecifique(new Dixcentimes());
            nombre3 = caisse.CapacitePieceSpecifique(new Vingtcentimes());
            nombre4 = caisse.CapacitePieceSpecifique(new Cinquantecentimes());
            nombre5 = caisse.CapacitePieceSpecifique(new Uneuro());
            nombre6 = caisse.CapacitePieceSpecifique(new Deuxeuro());
            nombre7 = caisse.CapaciteTotale();
            Afficheur.EtatMachineCaisse(nombre1, nombre2, nombre3, nombre4, nombre5, nombre6, nombre7);
        }
    }
}
