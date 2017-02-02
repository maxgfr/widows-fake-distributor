using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monnayeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Monnayeur m = new Monnayeur();
            Client client = new Client("Monsieur X",500);
            m.start(client);
            Console.ReadKey();
        }
    }
}
