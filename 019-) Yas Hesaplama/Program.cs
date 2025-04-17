using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019___Yas_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Merhaba ,");
            Console.Write("İsminiz :");
            string isim = Console.ReadLine();
            Console.Write("Soy isminiz :");
            string soyisim = Console.ReadLine();
            Console.Write("Doğum Yılınız :");
            string stryil = Console.ReadLine();

            Console.Clear();

            int intyil = Convert.ToInt32(stryil);

            int tarih = DateTime.Now.Year;                      //Burada Year dışında başka şeylerde seçebilirsin    
            int yas = tarih - intyil;



            Console.WriteLine("Merhaba" + " " + isim + " " + soyisim + " " + yas + " " + "yaşındasınız");
            Console.ReadLine();





        }
    }
}
