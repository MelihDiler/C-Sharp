using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011___Isim_Soyisim_Sehir___Alistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //////////*** ISIM SOYISIM SEHIR ***\\\\\\\\\\

            Console.WriteLine("Merhaba");
            Console.WriteLine();
            Console.Write("İsminiz nedir?");
            string isim = Console.ReadLine();
            Console.Write("Soyisminiz nedir?");
            string soyisim = Console.ReadLine();
            Console.Write("Yaşadığınız şehir nedir?");
            string sehir = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Şehir: " +  sehir);
            
            Console.ReadLine();






        }
    }
}
