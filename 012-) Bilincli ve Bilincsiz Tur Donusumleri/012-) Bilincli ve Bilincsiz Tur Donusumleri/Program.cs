using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012___Bilincli_ve_Bilincsiz_Tur_Donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                 //////////*** BILINCLI TUR DONUSUMU ***\\\\\\\\\\                     

            byte sayi1 = 100;  // byte 0 ile 255 arası değer alır.
                               // sayi1 = 256;  bu kodu kabul etmez hata verir. Çünkü alabileceği değerden fazla.

            int sayi2 = 256;   // int bu değeri alabilecek kapasite de

            int sayi3 = sayi1; // Burada bilinçli tür dönüşümü olmaktadır. Çünkü sayi1 byte ve sayi3 int. Int Byte değerlerinin
                               // tamamını kapsamaktadır. Bu sebeple bilinçli tür dönüşümüdür ve kabul eder.


                                                 //////////*** BILINCSIZ TUR DONUSUMU ***\\\\\\\\\\


            int sayi4 = 100;

            byte sayi5 = (byte)sayi4;    // Buna bilinçsiz tür dönüşümü denir. Normalde int byte alanından büyük ve giremez ama 
                                         // sayi4 int olmasına rağmen öyle bir değer almış ki byte alanı içerisinde ve bunu biz
                                         // biliyoruz. Sonrasında (byte) komutu ile bana güvenebilirsin bu değeri al diyoruz.
                                         // Kefil olmuş oluyoruz. Eğer kapsamadığı alandan bir değer verirsek "0" değerini atar.






        }
    }
}
