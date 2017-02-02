using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    public abstract class Pieces // Cette classe peut s'appeller tubes également !!!
    {
        public int valeur;
        public abstract void AjoutPiece(int nombre);
        public abstract void EnlevPiece(int nombre);
        public abstract int GetPiece();

        
    }
}
