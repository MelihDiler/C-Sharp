using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _010___Faaliyet_Alanlari
{
    internal class Program
    {

        static string s2 = "Ezgi Diler";

        static void Main(string[] args)
        {

            //////////*** FAALIYET ALANLARI ***\\\\\\\\\\                 

            string s1 = "Melih Diler";       // S1 stringinin faaliyet alanları içerisinde bulunduğu süslü parantezlerdir.

            s2 = "Panduf Diler";    // S2 üst blockda yer aldığı için alt block olan bu süslü parantez içerisinde değiştirebildik.


        }

        static void Test()
        {
            // Burada S1 değişkenine ulaşamazsın. Faaliyet alanı dışındadır.

            s2 = "Deneme";          // Burada da üst blockda yer alan değerlere ulaşabildik.

        }
    }
}
