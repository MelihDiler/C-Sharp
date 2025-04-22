using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045___Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan işlem numarasını alıyoruz (0, 1, 2, 3)
            Console.WriteLine("Lütfen işlem türünü seçiniz:");
            Console.WriteLine("0 - Para Yatırma");
            Console.WriteLine("1 - Para Çekme");
            Console.WriteLine("2 - Havale");
            Console.WriteLine("3 - Ödeme");
            Console.Write("Seçiminizi girin (0-3): ");

            // Kullanıcıdan girdi alıyoruz ve int'e çeviriyoruz
            int secim = Convert.ToInt32(Console.ReadLine());

            // Seçilen işlem türünü enum'a çeviriyoruz
            IslemTuru islem = (IslemTuru)secim;

            switch (islem)
            {
                case IslemTuru.ParaYatirma:
                    Console.WriteLine("Para yatırma işlemi gerçekleştiriliyor.");
                    break;
                case IslemTuru.ParaCekme:
                    Console.WriteLine("Para çekme işlemi gerçekleştiriliyor.");
                    break;
                case IslemTuru.Havale:
                    Console.WriteLine("Havale işlemi gerçekleştiriliyor.");
                    break;
                case IslemTuru.Odeme:
                    Console.WriteLine("Ödeme işlemi gerçekleştiriliyor.");
                    break;
                default:
                    Console.WriteLine("Bilinmeyen işlem.");
                    break;
            }

            Console.ReadLine();













        }
    }
}
