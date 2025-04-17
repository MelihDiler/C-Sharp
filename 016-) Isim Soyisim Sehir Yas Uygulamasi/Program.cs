using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016___Isim_Soyisim_Sehir_Yas_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                           //////////*** BOLUM SONU ALISTIRMA 1 ***\\\\\\\\\\ 

                                                     //////////*** ISIM SOYISIM YAS SEHIR UYGULAMASI ***\\\\\\\\\\

            string isim;
            string soyisim;
            string sehir;
            string yaşStr;


            Console.WriteLine("Merhaba");
            Console.WriteLine();
            Console.Write("Adınız: ");
            isim = Console.ReadLine();
            Console.Write("Soyisim: ");
            soyisim = Console.ReadLine();
            Console.Write("Yaşınız: ");
            yaşStr = Console.ReadLine();
            Console.Write("Yaşadığınız şehir: ");
            sehir = Console.ReadLine();

            Console.Clear();

            int yaş = Convert.ToInt32(yaşStr);


            Console.WriteLine("Adınız: " + isim);
            Console.WriteLine("Soyadınız: " + soyisim);
            Console.WriteLine("Yaşınız: " + yaş);
            Console.WriteLine("Şehir: " + sehir);
            Console.ReadLine();


            // Yaşı direkt kısa yazmak istersek: int yaş = ConvertToInt32(Console.ReadLine());





        }
    }
}
