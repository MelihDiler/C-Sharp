using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024___IF_ELSE_SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {

                                             //////////////////// KARAR YAPILARI (IF) \\\\\\\\\\\\\\\\\\\\
                                        ///////////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            // if yazıp TAB TAB yaparsan şablon çıkar.

            Console.Write("Sayı 1 değerini giriniz : ");
            decimal sayi1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Sayı 2 değerini giriniz : ");
            decimal sayi2 = Convert.ToDecimal(Console.ReadLine());
            decimal toplam = sayi1 + sayi2;

            //bool toplamKontrol = toplam > 50;

            //if (toplamKontrol)
            //{
            //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyüktür");
            //}

            // Daha kısa hali aşağıdadır.

            if (toplam >= 100)
            {                                        // Eğer çalıştıracağın şey tek satırsa süslü parantez kullanmak zorunda değilsin.
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 100'den büyük veya eşittir");

            }
            else if (toplam >= 50)
            {
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50'den büyük veya eşittir");
            }
            else if (toplam >= 40)
            {
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 40'dan büyük veya eşittir");
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 40'den küçüktür.");
            }

            Console.ReadLine();






                                           //////////////////// KARAR YAPILARI (SWITCH) \\\\\\\\\\\\\\\\\\\\
                                      /////////////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            Console.Write("Hangi Ay :");
            string kullaniciGelen = Console.ReadLine();

            switch (kullaniciGelen)                             // Tek bir değişkenin sonucuna göre farklı işlemler için kullanılır.
            {                                                   // Switch içerisinde yazılan caselerin hepsini bilir ve uyuşanı direk çalıştırır. If gibi satır satır inmez.
                case "Ocak":                                    // Birden çok case yazılabilir.
                case "ocak":                                    // Büyük küçük harf duyarlılığı vardır.
                    Console.WriteLine("01");
                    break;
                case "Şubat":
                    Console.WriteLine("02");
                    break;
                case "Mart":
                    Console.WriteLine("03");
                    break;
                case "Nisan":
                    Console.WriteLine("04");
                    break;
                case "Mayıs":
                    Console.WriteLine("05");
                    break;
                case "Haziran":
                    Console.WriteLine("06");
                    break;
                case "Temmuz":
                    Console.WriteLine("07");
                    break;
                case "Ağustos":
                    Console.WriteLine("08");
                    break;
                case "Eylül":
                    Console.WriteLine("09");
                    break;
                case "Ekim":
                    Console.WriteLine("10");
                    break;
                case "Kasım":
                    Console.WriteLine("11");
                    break;
                case "Aralık":
                    Console.WriteLine("12");
                    break;
                default:
                    Console.WriteLine("Belirtilen değerlerin dışında bir değer girdiniz");
                    break;

            }
            Console.ReadLine();



            


        }
    }
}
