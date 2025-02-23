using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022___Not_Alistirmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sinav1;
            decimal sinav2;
            decimal sinav3;


            Console.WriteLine("Lütfen aşağıdaki bilgileri doldurunuz...");
            Console.Write("1. Sınav Notunu Giriniz : ");
            sinav1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("2. Sınav Notunu Giriniz : ");
            sinav2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("3. Sınav Notunu Giriniz : ");
            sinav3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Geçer bilgisini almak için 'ENTER' tuşuna basınız : ");
            Console.ReadLine();
            Console.Clear();

            // decimal topla = sinav1 + sinav2 + sinav3;          // Bu uzun yöntemdir.
            // decimal ortalama = topla / 3;

            decimal ortalama = (sinav1 + sinav2 + sinav3) / 3;    // Bu da kısa hali. Parantez içindeki işlemin sonucu parantezin dışına çıkar ve onunla işlem devam eder.
            bool sonuc = ortalama >= 45;

            Console.WriteLine(sonuc);
            Console.ReadLine();





        }
    }
}
