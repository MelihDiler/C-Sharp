using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031___While_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                      ////////////////////WHILE DONGUSU\\\\\\\\\\\\\\\\\\\\
                                                  ///////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\



            // True geldiği sürece çalışır. False olursa ya da break; anahtar kelimesi kullanılırsa döngüden çıkar.


            #region While döngüsü genel kullanımı. (Ekrana 1 - 10 kadar değerleri yazdırma.)

            // For döngüsüyle yapmak isteseyidik.
            /////////////////////////////////////
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            // While döngüsüyle yapmak.
            ///////////////////////////
            int sayac = 1;
            while (sayac <= 10)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            Console.ReadLine();

            #endregion

            #region Kullanıcıdan alınan değere göre ekrana 1 eksilterek 0 değerine ulaşıncaya kadar ekrana yazdırma.

            int kullDeger = 0;
            Console.Write("Lütfen bir değer giriniz:");
            kullDeger = Convert.ToInt32(Console.ReadLine());

            while (kullDeger > -1)
            {
                Console.WriteLine(kullDeger);
                kullDeger--;
            }
            Console.ReadLine();

            #endregion

            #region Kullanıcıdan gelen değerlerin toplamını ekrana yazdıralım. 0'dan küçük bir değer girişi yapılırsa toplama işlemini bitirelim ve ekana toplam sonucu yazalım.

            Console.WriteLine("Lütfen toplamlarını istediğiniz bir değer giriniz:");
            Console.WriteLine("Not: -1 değeri işlemlerinizi durdurur.");
            int kullToplam = 0;

            while (true)
            {

                int kullDeger1 = Convert.ToInt32(Console.ReadLine());
                if (kullDeger1 == -1)
                    break;
                else
                {
                    kullToplam = kullDeger1 + kullToplam;
                }


            }
            Console.WriteLine("Toplam Değer : {0}", kullToplam);
            Console.ReadLine();

            #endregion

            #region Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama.

            Console.WriteLine("Lütfen sistemin üretmiş olduğu sayıyı tahmin ediniz. Değerler 1 ile 10 arasında olacaktır.");
            int sayacTahmin = 1;
            while (true) 
            {
                int sistemUretSayi = 0;
                Random rnd = new Random();              // Burası nesne tanımı. İlerde işleyeceğiz.
                sistemUretSayi = rnd.Next(1, 10);       // 1 ile 10 arasında değer oluşturup değişkenime tanımlıyor.

                int kullDegerTahmin = Convert.ToInt32(Console.ReadLine());
                if (kullDegerTahmin == sistemUretSayi)
                {
                    Console.WriteLine("Tebrikler {0}. denemede doğru bildiniz...", sayacTahmin);
                    break;                              // While sonsuz çalışacağı için, doğru bilince break ile while'dan çıkıyoruz.
                }
                else 
                {
                    Console.WriteLine("Sistemin oluşturmuş olduğu değer {0} tekrar deneyiniz", sistemUretSayi);
                }
                sayacTahmin++;
            }

            Console.ReadLine();

            #endregion






        }
    }
}
