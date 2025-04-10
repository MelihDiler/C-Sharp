using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014___Convert___Parse_Uygulamaları
{
    internal class Program
    {
        static void Main(string[] args)
        {

                                         //////////*** CONVERT - PARSE ***\\\\\\\\\\
            
            //** Örnek 1 **\\

            string metin1 = "100";
            /* int s1 = metin1; Bu şekilde tür farkından dolayı kabul etmez.
               int s1 = (int)metin1; Bu şekilde söz vererek de olmuyor. */ 

            int s1 = int.Parse(metin1);           // Burada diyoruz ki metin1 int olabilir onu çevir o şekilde yaz.
                                                  // Söz vermekten farkı çevirerek içine yazması.
            int s2 = Convert.ToInt32(metin1);

            //** Örnek 2 **\\

            string metin2 = "true";

            bool b1 = bool.Parse(metin2);
            bool B2 = Convert.ToBoolean(metin2);

                                     //////////*** CONVERT İLE PARSE FARKI ***\\\\\\\\\\

            string metin3 = null; // Null hiçbir şey yok demektir. Boşluk bile bir değerdir.

            decimal d1 = decimal.Parse(metin3); // Burada değer null olamaz hatası alır. 
            decimal d2 = Convert.ToDecimal(metin3); // Burada null olamaz ama hata vermiyor. default değeri yani "0" kalıyor.
                                                    // Böylelikle yazılımda sorun teşkil etmiyor.
                                                    // Kıyaslama ile 0 varsa şunu yap diye yazılımı çevirebiliriz.
                                                    // Bu şekilde kimse yazılımda bir sorun oluştu diyemez.

        }
    }
}
