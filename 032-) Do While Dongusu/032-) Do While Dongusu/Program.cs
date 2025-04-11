using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032___Do_While_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                    ////////////////////DO WHILE DONGUSU\\\\\\\\\\\\\\\\\\\\
                                               /////////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\



            // While'dan farkı: şart ne olursa olsun bir kere çalışır.

            do
            {
                Console.WriteLine("Merhaba Do While");
            } while (1 == 2);                                   // 1 sayısı 2ye eşit olmadığı için bir kere çalışır ve ardından şart 
            Console.ReadLine();                                 // sağlanmadığı için döngüden çıkar. 
            Console.Clear();


            #region Ödev 1: Kullanıcıyı do while içerisine alın ve kullanıcı adı ve şifre sorun. Kullanıcı adı: Demo Şifre: Demo, eğer kullanıcı bu değerleri bilirse döngüden çıkın ve başarılı yazın. Eğer yanlış giriş yapıyorsa do while ile ilgili değerleri sormaya devam edin.

            // string kullAdi;  Eğer ki kullAdi bir değer almadan kullanılırsa hata alırız. O yüzde aşağıdaki kodu yazdık.
            // string sifre;

            string kullAdi = string.Empty;
            string sifre = string.Empty;

            do
            {
                Console.WriteLine("Lütfen kullanıcı adı ve şifrenizi giriniz...");
                Console.Write("Kullanıc Adı: ");
                kullAdi = Console.ReadLine();
                Console.Write("Şifre: ");
                sifre = Console.ReadLine();
                Console.Clear();


            } while (kullAdi != "Demo" && sifre != "Demo");
            Console.WriteLine("Kullanıc adı ve şifre doğru...");
            Console.ReadLine();

            #endregion

            #region Ödev 2: Kullanıcıdan 1 ile X arasında bir sayı girmesini isteyin. Daha sonra sistem kullanıcının girmiş olduğu 1 ile X değerleri arasında bir sayı tahmini yapsın. Daha sonra sistemin tahmin ettiği sayıyı bulmaya çalışsın. Bulamazsa ise yeniden sorsun. Ne zaman bulursa Y kadar denemede buldunuz desin.

            int kullDeger = 0;
            int sayac = 0;
            int tahmin = 0;


            Console.Write("Lütfe tahmin aralığınız için en yüksek değeri giriniz:");
            kullDeger = Convert.ToInt32(Console.ReadLine());

            int sistemUretSayi = 0;
            Random rnd = new Random();              // Burası nesne tanımı. İlerde işleyeceğiz.
            sistemUretSayi = rnd.Next(1, kullDeger);
            Console.Clear();

            do
            {
                sayac++;
                Console.Write("{0}. hakkınız, üretilen sayıyı tamin ediniz: ", sayac);
                tahmin = Convert.ToInt32(Console.ReadLine());

            } while (tahmin != sistemUretSayi);
            Console.WriteLine("{0}. tahmininizde doğru sayıyı buldunuz...", sayac);
            Console.ReadLine();


            #endregion


        }
    }
}
