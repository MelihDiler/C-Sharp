using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046___Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {   //  Tip guvenligi vardir. Hangi tipte olusturulduysa sadece o tipte eleman kabul eder.


            List<int> rakamlar = new List<int>();

            rakamlar.Add(0);
            //  rakamlar.Add("0");           HATA verir. cunku sadece int kabul eder.
        }
    }
}
