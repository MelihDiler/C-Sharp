using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015___Var_Anahtar_Kelime_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

                                                //////////*** VAR ***\\\\\\\\\\

            int s1 = 10;
            var s2 = "Melih";   // Burada string değeri tanımlandığı için s2 direkt string oldu. Daha sonra string dışında bir
                                // değer atayamazsın uygulama boyunca değişmez.
            var s3 = 100;       // Buna da yazı atayamayız.

            // s2 = 10;    Burada s2 ilk tanımlanığında "var" ile stringe dönüştürüldü o yüzden sayısal değer alamaz.
            // Fakat "10" değerini alır. Çünkü string. 
             



        }
    }
}
