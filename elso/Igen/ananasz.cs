using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Igen
{
    internal class ananasz
    {
        public ananasz()
        {
        
        }
        public void korte()
        {
            Console.WriteLine("Adj meg egy számot!");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros");
            }
            if (szam % 2 == 1)
            {
                Console.WriteLine("A szám páratlan");
            }
            Console.ReadKey();
        }
    }
}
