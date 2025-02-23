using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029___For_Donguleri
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Sabit döngü tipleri = For ve Foreach            * Kaç kere döngüye gireceği başta yazılır ve sabittir.
            // Şartlı döngü tipleri = While ve Do While        * TRUE oldukça şart sağlanır.


                                                  //////////////////// FOR DÖNGÜSÜ \\\\\\\\\\\\\\\\\\\\
                                             ///////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


            // For ( sayaç; şart; sayaç artış işlemi )
            // {
            //     Tekrar edilmesini istediğimiz kod bloğu
            // }
            #region For döngüsü genel kullanımı
            for (int i = 0; i <= 10; i++)                  // İkişer ikişer arttırmak için i+=2 yazmalıyız.
            {                                             // İç içe for döngülerinde sayaç değişken adı değişmeli "i" bir kere yazılabilir.
                Console.WriteLine("Ben bir for döngüsüyüm");
            }
            #endregion

            #region Ekran üzerinde 1 - 10 arasındaki değerleri yazdırma.
            for (int i = 1; i <= 10; i++)                // Sayacı 1'den başlatmamızın sebebi istediğimiz değer 1'den başlayıp 10'a kadar gidecek.
            {                                             // Şartı "9" yapıp sayacı yine "0" yapmamamızın sebebi ise biz ekrana i değerini yazdıracağız. 
                Console.WriteLine(i + ". tekrar !");
            }
            Console.ReadLine();
            #endregion

            #region 1 - 100 arasındaki çift sayıları ekrana yazdırma.
            for (int sayac = 1; sayac <= 100; sayac++)
            {
                if (sayac % 2 == 0)
                {
                    Console.WriteLine(sayac);
                }
            }
            Console.ReadLine();
            #endregion

            #region 1 - 100 arasındaki çift sayıların toplamı.
            int toplam = 0;
            int toplam2 = 1;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    // toplam = toplam + i;
                    toplam += i;                  // Üstteki ile aynı ve kısa halidir.
                }
            }
            Console.WriteLine("Toplam değer: {1}", toplam, toplam2); // Burada direkt toplam yazıp değeri de alabilirdik fakat indeks kullandık.
            Console.ReadLine();                                      // Yani 0. indeks toplam, 1. indeks toplam 2 olduğu için 1 değerini verir.


            #endregion

            #region Kullanıcıdan değer alacağız ve o değerin faktöriyelini vereceğiz.

            Console.Write("Lütfen faktöriyelini istediğiniz değeri giriniz:");
            int kullDeger = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;

            for (int i = kullDeger; i != 1; i--)
            {
                faktoriyel *= i;
            }
            Console.WriteLine("{0} değerinin faktöriyel sonucu : {1}", kullDeger, faktoriyel);
            Console.ReadLine();

            #endregion

            #region Sonsuz döngü oluşturmak.
            // for (; ; ) 
            // {
            //     Console.WriteLine("Merhaba ben bir sonsuz döngüyüm");       Bu bir sonsuz döngüdür. Bundan çıkabilmek için de aşağıda
            // }                                                               Break ve Continue anahtar kelimelerinden faydalanacağız.

            //int sonsuzSayac = 0;
            //for (; ; )                                          // for şartı olmadığı için sonsuz döngüdür fakat içine girince direkt 
            //{                                                   // sayacımız 1 artıyor ve if bloğu ikincisinde çalışıp break anahtar
            //    sonsuzSayac++;                                  // kelimesiyle döngüden çıkıyor.
            //    if (sonsuzSayac == 2)
            //        break;                                      // break anahtar kelimesinin nerede yazıldığının bir önemi yok. Hangi
            //    Console.WriteLine(sonsuzSayac);                 // döngü içine denk geliyorsa oradan çıkartır. break döngülere ait bir
            //                                                    // anahtar kelimedir.
            //    Console.WriteLine("Ben bir sonsuz döngüyüm");
            //}


            int sonsuzSayac = 0;
            for (; ; )
            {
                sonsuzSayac++;
                if (sonsuzSayac == 2)
                    continue;                                     // continue anahtar kelimesi çalıştığında sonraki kodları çalıştırmadan
                Console.WriteLine(sonsuzSayac);                   // for döngüsünde başa döner. Yani sayaç hep sayar ama ekrana 2 değerini
                if (sonsuzSayac == 6)                             // yazmadan 3'e atlar. Break kullanmamızın sebebide ekranda sonsuz değerler
                    break;                                        // atanacağı için 6'da durdurduk ki 2'yi yazmadan geçmiş mi görelim diye.

            }
            Console.ReadLine();

            #endregion
            Console.Clear();
            #region İç içe for döngüsü
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)                      // Burada kritik nokta şu: i = 1 oldu. içerdeki for döngüsüne girdi.
                {                                                 // j = 1 oldu çalıştı ve 1 arttı. o yüzden j<=i şartı sağlanmadı çıktı.
                    Console.Write("*");                           // işte püf nokta burada başlıyor. içerideki fordan çıkıp tekrar girdiğinde
                }                                                 // j tekrar 1 olur kaldığı yerden devam etmez çünkü şart sağlanmadı ve döngüden çıktı.  
                Console.WriteLine();
            }
            Console.ReadLine();
            #endregion

            #region
            int sonuc = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    sonuc = i * j;
                    Console.Write(i + "*" + j + "=" + sonuc + "\t");   // Burada Console.WriteLine deseydik çarpım tablosunu 
                }                                               // yukarıdan aşağıya doğru yazacaktı. Console.Write diyerek
                Console.WriteLine();                            // yan yana yaptık. "\t" ile de her Console.Write sonrasında
            }                                                   // büyük bir boşluk bırakmış olduk. Bu sayede ilk satır 1'ler, 2. satır
            Console.ReadLine();                                 // 2'ler, 3. satır 3'lerin çarpım tablosu yer alır. İlkinde ise 1'ler
                                                                // yukarıdan aşağıya sonra satır boşluk bırakıp 2'ler yukarıdan aşağıya.
            #endregion







        }
    }
}
