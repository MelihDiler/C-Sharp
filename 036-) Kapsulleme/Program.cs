using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036___Kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.setIsim("Melih");                     //  ogrenci1.isim ile ulasamadik cunku private tanimliydi. Bu sebeple publictanimlanan metot ile ulastik o da setIsim
            Console.WriteLine(ogrenci1.getIsim());         //  ogrenci1.isim ile ulasamadik cunku private tanimliydi. Bu sebeple publictanimlanan metot ile ulastik o da getIsim
            Console.ReadLine();









        }
    }
}
