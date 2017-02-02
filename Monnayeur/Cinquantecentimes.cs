using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    public class Cinquantecentimes : Pieces, IEquatable<Cinquantecentimes>
    {
        public static int Capacite = 100;

        public Cinquantecentimes () {
            valeur = 50;
        }

        public override void AjoutPiece(int nombre)
        {
            Capacite = Capacite - nombre;
        }

        public override void EnlevPiece(int nombre)
        {
            Capacite = Capacite + nombre;
        }

        public override int GetPiece()
        {
            return Capacite;
        }
        public override string ToString()
        {
            return "Pièce de 50 centimes";
        }

        public override bool Equals(object right)
        {

            if (object.ReferenceEquals(right, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))
            {
                return true;
            }

            if (this.GetType() != right.GetType())
            {
                return false;
            }

            return this.Equals(right as Cinquantecentimes);
        }


        public bool Equals(Cinquantecentimes other)
        {
            return (this.valeur == other.valeur);
        }

        public override int GetHashCode()
        {
            return valeur;
        }
    }
}
