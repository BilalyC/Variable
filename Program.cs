using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = 2;
            y = 5;
            z = 4;

            Console.WriteLine("Les 3 valeurs sont respectivement " + x + ", " + y + " et " + z);

            Console.WriteLine("Le produit entre la troisieme valeur et la somme des deux premieres valeurs est " + (z *(x + y)));
        }
    }
}
