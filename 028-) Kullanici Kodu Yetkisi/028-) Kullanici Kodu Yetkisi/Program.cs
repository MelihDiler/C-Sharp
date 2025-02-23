using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028___Kullanici_Kodu_Yetkisi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kullanıcı Kodu : ");
            string kullKodu = Console.ReadLine();

            kullKodu = kullKodu.ToUpper();           // Büyük küçük harf duyarlılığını sonlandırmış oluyoruz çünkü tüm harfleri büyütüp
                                                     // sonra tekrar kendisine yazıyor.

            switch (kullKodu)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine("Admin yetkisine sahipsiniz...");
                    break;
                case "DD":
                    Console.WriteLine("Güçlü kullanıcı yetkisine sahipsiniz...");
                    break;
                case "FF":
                case "EE":
                case "GG":
                    Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz...");
                    break;
                default:
                    Console.WriteLine("Hatalı kullanıcı kodu...");
                    break;

            }
            Console.ReadLine();






        }
    }
}
