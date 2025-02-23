using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026___Dort_Islem_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {


                                                  //////////////////// DÖRT İŞLEM \\\\\\\\\\\\\\\\\\\\\\\\\
                                             ///////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\




            decimal sayi1 = 0;                         // Eğer ki bunları If bloğu içerisinde yazsaydık hata alacaktık. Çünkü içerdeki
            decimal sayi2 = 0;                         // değer dışarı çıkamayacağı için dışarıda tanımladık. Ayrıca "0" değeri vermemizin
                                                       // sebebi de local değişkenler değer almadan çalışmazlar.


            Console.WriteLine("MENÜ");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkartma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.Write("Seçiniz : ");
            string secim = Console.ReadLine();
            Console.Clear();
            if (secim == "1" || secim == "2" || secim == "3" || secim == "4")
            {
                Console.Write("1. Sayı değerini giriniz : ");
                sayi1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("2. Sayı değerini giriniz : ");
                sayi2 = Convert.ToDecimal(Console.ReadLine());

                Console.Clear();

            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız...");
                Console.ReadLine();
            }


            if (secim == "1")
            {
                decimal toplam = sayi1 + sayi2;
                Console.WriteLine("Sonuç : " + toplam);
            }
            else if (secim == "2")
            {
                decimal fark = sayi1 - sayi2;
                Console.WriteLine("Sonuç : " + fark);
            }
            else if (secim == "3")
            {
                decimal carpim = sayi1 * sayi2;
                Console.WriteLine("Sonuç : " + carpim);
            }
            else if (secim == "4")
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine("Bölen '0' olamaz!");
                }
                else
                {
                    decimal bolum = sayi1 / sayi2;
                    Console.WriteLine("Sonuç : " + bolum);
                }
                Console.ReadLine();
            }

            Console.ReadLine();



            //ctrl+k+d ile satırları hizaya alabilirsin!!!!!!!!!!!





        }
    }
}
