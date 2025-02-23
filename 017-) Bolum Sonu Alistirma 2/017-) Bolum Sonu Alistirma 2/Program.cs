using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017___Bolum_Sonu_Alistirma_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

                                           //////////*** BOLUM SONU ALISTIRMA 2 ***\\\\\\\\\\

            // Soru 1 : String olarak verilen değeri bool tipine dönüştürün
            string metin1 = "True";
            bool b1 = Convert.ToBoolean(metin1);



            // Soru 2 : Int içerisinde olan 100 değerini byte ve float değişken tiplerine dönüştürün.
            int s1 = 100;
            byte b2 = (byte)s1;
            float f1 = s1;         // Daha  büyük ir değişken olduğu için parantez için yazıp kefil olmadık. Bilinçli dönüşüm.


            // Soru 3 : Byte değişken içerisinde olan tipi Decimal değişken tipine dönüştürün.
            byte b3 = 10;
            decimal d1 = b3;


            
    }
}
