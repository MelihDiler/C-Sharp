using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004___String_Degiskeni
{
    internal class Program
    {
        static void Main(string[] args)
        {

                                             //////////*** STRING ***\\\\\\\\\\


            string isimSoyisim = "Melih Diler";
            Console.WriteLine(isimSoyisim);                         // "Melih Diler" değerini verir.

            isimSoyisim = "Ezgi Diler";
            Console.WriteLine(isimSoyisim);                         // "Ezgi Diler" değerini verir.

            string buyukKarakter = isimSoyisim.ToUpper();           // "EZGİ DİLER" değerini verir.
            string kucukKarakter = isimSoyisim.ToLower();           // "ezgi diler" değerini verir.
            string belirliBirBolum = isimSoyisim.Substring(2, 4);   // 2'den başla 4 karakter al demek. İlk karakter 0'dır. Yani
                                                                    // 0=E 1=z 2=g 3=i 4="boşluk" 5=D ...   "gi D" değerini verir.



        }
    }
}
