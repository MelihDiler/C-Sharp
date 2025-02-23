using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021___Karsilastirma_ve_Kontrol_Operatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {                                       //////////////////// KARŞILAŞTIRMA OPERATORLERİ \\\\\\\\\\\\\\\\\\\\
                                           ///////////////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


            int s1 = 100;
            int s2 = 150;
            int s3 = 100;

            // Büyük mü karşılaştırması ">"
            bool sonucBuyuk1 = s1 > s2;                // 100, 150'den büyük olmadığı için sonuç False dönecektir.
            bool sonucBuyuk2 = s2 > s1;                // 150, 100'den büyük olduğu için True dönecektir.

            // Küçük mü karşılaştırması "<"
            bool sonucKucuk1 = s1 < s2;                // 100, 150'den küçük olduğu için True dönecektir.
            bool sonucKucuk2 = s1 < s3;                // 100, 100!den küçük değil eşittir. Flase dönecektir.

            // Eşit mi karşılaştırması "==" - "!="
            bool sonucEsit1 = s1 == s2;                // 100, 150'ye eşit olmadığı için False dönecektir.
            bool sonucEsit2 = s1 == s3;                // 100, 100'e eşit olduğu için True dönecektir.
            bool sonucEsit3 = s1 != s2;                // 100, 150'ye eşit olmadığı için True dönecektir.

            // Büyük veya eşit mi ">="
            bool sonucBuyukEsit1 = s1 >= s2;           // İlk önce büyük mü diye bakar büyük olmadığı içim eşit mi diye bakar ve False dönecektir.
            bool sonucBuyukEsit2 = s1 >= s3;           // S1, S3'den büyük değildir ama eşittir. True döndürür.

            // Küçük veya eşit mi "<="
            bool sonucKucukEsit11 = s1 <= s2;          // 100, 150'den küçük olduğu için direkt True döndürecektir.






                                                 //////////////////// KONTROL AKIŞI OPERATORLERİ \\\\\\\\\\\\\\\\\\\\
                                            ///////////////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\




            // Is operatörü                            // Bir nesnenin belirli bir türde olup olmadığını kontrol etmek için kullanılır.
            object o1 = s1;
            bool isKontrol1 = o1 is int;               // o1 içerisinde int değeri saklıyor fakat hala object türündedir.
            bool isKontrol2 = o1 is string;            // Bu sebeple o1'i int'a çevirmeden örneğin toplamı işleminde kullanamazsın.
            //int d1 = (int)o1;                        // o1'in int'a sığacağını bilip bize güven diyerek bilinçsiz dönüşüm yapıyoruz.
            //int sonuc = d1 + s2;                     // Ardından toplama işleminde kullanabiliyoruz.
            int sonuc = Convert.ToInt32(o1) + s2;      // Ya da o1'i int'a çevirip direkt o1'i de kullanabiliriz.


            // As operatörü                            // Bir nesneyi belirli bir türe dönüştürmek için kullanılır.
            // Eğer dönüşüm mümkünse, nesne belirtilen türe dönüştürülür; aksi takdirde null döner.
            // Bu, dönüşüm işlemlerinde güvenli bir yöntemdir çünkü hata fırlatma riski taşımaz.
            string isimSoyisim = "Melih Diler";
            object objectString = isimSoyisim;         // Burada objectString değişkeninin içine "Melih Diler" değerini değişken tipiyle aktaracak.
            string sonucStr = objectString as string;  // objectString'in içindeki değer string ise sonucStr değişkenine string olarak atayacak.









        }
    }
}
