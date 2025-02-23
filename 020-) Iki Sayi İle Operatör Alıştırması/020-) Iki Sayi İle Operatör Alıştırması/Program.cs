using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020___Iki_Sayi_İle_Operatör_Alıştırması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal toplam;
            decimal fark;
            decimal bolme;
            decimal carpma;
            decimal mod;



            Console.Write("Sayı 1 değerini giriniz: ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());     // Burada Convert.ToInt32 demedik.
            Console.Write("Sayı 2 değerini giriniz: ");                // Çünkü ondalıklı sayıları yuvarlama yapmasını istemedik.
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            bolme = sayi1 / sayi2;
            carpma = sayi1 * sayi2;
            mod = sayi1 % sayi2;

            Console.WriteLine("Toplam = " + toplam);
            Console.WriteLine("Fark = " + fark);
            Console.WriteLine("Bölme = " + bolme);
            Console.WriteLine("Çarpma = " + carpma);
            Console.WriteLine("Mod alma = " + mod);



            Console.ReadLine();



        }
    }
}
