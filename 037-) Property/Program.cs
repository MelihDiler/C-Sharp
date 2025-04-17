using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037___Property
{
    internal class Program
    {//  Kapsullemenin modern yontemi...
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();              

            musteri1.KILO = 85;                            //  KILO property adidir. Eger ki atama yaparsan SET blocklarini calistirir.

            Console.WriteLine(musteri1.KILO);              //  KILO property adidir. Eger ki bilgi alma yaparsan GET blocklarini calistirir.



        }
    }
}
