using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025___Kullanici_kodlari___IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                             //////////////////// KULLANICI ADI ŞİFRE \\\\\\\\\\\\\\\\\\\\
                                        ///////////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


            string kullAdi = "admin";
            string sifre = "12345";

            Console.Write("Kullanıcı adı: ");
            string inkullAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            string inSifre = Console.ReadLine();

            Console.Clear();

            if (kullAdi == inkullAdi && sifre == inSifre)
            {
                Console.WriteLine("Kullanıcı adı ve şifre doğru");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre yanlış");
            }

            Console.ReadLine();

                                             //////////////////// KULLANICI KODLARI \\\\\\\\\\\\\\\\\\\\
                                        //////////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            Console.WriteLine("Lütfen kullanıcı kodunuzu giriniz:");

            string kod = Console.ReadLine();         // string kod = Console.ReadLine().ToUpper(); Bu sekilde tek satirda da olabilirdi.
            kod = kod.ToUpper();                     // Kullanıcının girdiği değerleri alıp tüm harfleri büyütüp tekrar kendisine yazıyor.

            if (kod == "ABC" || kod == "123" || kod == "236" || kod == "CMK")
            {
                Console.WriteLine("Kullanıcı girişiniz başarılı");
            }
            else if (kod == "HHH" || kod == "BBB" || kod == "MMM")
            {
                Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı kodu");
            }
            Console.ReadLine();

        }
    }
}
