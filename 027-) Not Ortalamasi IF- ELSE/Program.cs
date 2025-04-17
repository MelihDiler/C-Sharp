using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027___Not_Ortalamasi_IF__ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Not ortalaması sistemine hoşgeldiniz...");

            Console.Write("İsim ve Soyisim : ");
            string isimSoyisim = Console.ReadLine();
            Console.Write("Not 1: ");
            decimal not1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Not 2: ");
            decimal not2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Not 3: ");
            decimal not3 = Convert.ToDecimal(Console.ReadLine());

            decimal ortalama = (not1 + not2 + not3) / 3;

            if (ortalama >= 90 && ortalama <= 100)
            {
                Console.WriteLine("Başarılı Tebrikler...");
            }
            else if (ortalama >= 70 && ortalama < 90)
            {
                Console.WriteLine("İyi ile geçtiniz...");
            }
            else if (ortalama >= 45 && ortalama < 70)
            {
                Console.WriteLine("Orta ile geçtiniz...");
            }
            else if (ortalama < 45)
            {
                Console.WriteLine("Kaldınız");
            }
            else
            {
                Console.WriteLine("Notlarınızı Kontrol Ediniz...");
            }

            Console.ReadLine();











        }
    }
}
