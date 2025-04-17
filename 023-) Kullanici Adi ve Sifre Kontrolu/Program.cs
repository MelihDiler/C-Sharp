using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023___Kullanici_Adi_ve_Sifre_Kontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string kullAdi = "admin";
            string sifre = "123";

            Console.Write("Kullanıcı adınızı giriniz: ");
            string ad = Console.ReadLine();
            Console.Write("Şifresinizi giriniz: ");
            string sif = Console.ReadLine();

            bool dogruAd = kullAdi == ad;
            bool dogruSif = sifre == sif;

            bool dogru = dogruAd == true & dogruSif == true;

            Console.WriteLine(dogru);
            Console.ReadLine();











        }
    }
}
