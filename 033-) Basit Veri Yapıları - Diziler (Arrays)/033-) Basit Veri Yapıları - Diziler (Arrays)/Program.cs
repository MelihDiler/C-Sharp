using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033___Basit_Veri_Yapıları___Diziler__Arrays_
{
    internal class Program
    {
        static void Main(string[] args)
        {                                               /////////////////////DİZİLER\\\\\\\\\\\\\\\\\\\\\
                                                   /////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


            // Sabit boyutlu: Dizinin boyutu oluşturulduktan sonra değiştirilemez.
            // Hızlı erişim: Elemanlara indeks numarası ile hızlı erişim sağlar.
            // Avantajlar: Hafızada verimli ve elemanlara hızlı erişim sunar.
            // Dezavantajlar: Boyut sabit olduğu için dinamik veri yönetimi zordur.
            // Dizinin boyutunu arttırmak için daha büyük boyutlu dizi tanımlayıp var olanı bunun içerisine aktarabiliriz.
            // Koleksiyonlarda limit otomatik artar

            string[] ogrenciIsimleriListesi = new string[5];                    // string türünde dizi tanımladık, ardından buna                                                                             ogrenciIsimleriListesi adını verdik, sonrasında ise new                                                                      diyerek bellekte 5 elemanlı bir string dizi oluştur dedik.
            // Nasıl değer eklenir?
            // indeks değeri 0'dan başlar.


            ogrenciIsimleriListesi[0] = "Melih Diler";                          // Bu şekilde değer eklenir.
            ogrenciIsimleriListesi[1] = "Ezgi Diler";
            ogrenciIsimleriListesi[2] = "Panduf Diler";
            ogrenciIsimleriListesi[3] = "Defne Diler";
            ogrenciIsimleriListesi[4] = "İsim Soyisim";

            Console.WriteLine(ogrenciIsimleriListesi[1]);                       // Bu şekilde ekrana yazılır.
            Console.ReadLine();

            #region oluşturmuş olduğumuz dizimizin içerisindeki elemanları ekrana yazdıralım.

            foreach (string item in ogrenciIsimleriListesi)                     // Dizi elemanları string olduğu için string item ile
            {                                                                   // in ogrenciIsimleriListesi'nde ilk indeksten son indekse
                Console.WriteLine(item);                                        // kadar tek tek ekrana yazar.             
            }
            Console.ReadLine();

            //////////FOR İLE NASIL YAPILIR?\\\\\\\\\\


            for (int i = 0; i < ogrenciIsimleriListesi.Length; i++)
            {
                string gelenIsim = ogrenciIsimleriListesi[i];                   // Burada "i" koymamızın sebebi indeks "0"dan başlar ve
                Console.WriteLine(gelenIsim);                                   // bizde "i" değerini ilk başta "0" atadık. Bu sayede
            }                                                                   // dizinin en başından başlar ve sayaç ile arttıkça dizinin
                                                                                // bir sonraki indeksini alır. İstediğimiz gibi bunlara
                                                                                // müdahale ederek indeksin istediğimiz yerinden başlayabilir.
            Console.ReadLine();

            #endregion

            #region Genel Kullanımı

            string[] Isimler = new[] { "Melih Diler", "Ezgi Diler", "Panduf Diler", "Defne Diler" };

            foreach (string item in Isimler)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.Clear();

            #region Uygulama 1 : int veri tipinde bir dizi oluşturalım, kullanıcımız dizinin kaç elemanlı olacağı bilgisini bize versin ve dizi içindeki alanlara değer ataması yapsın. Daha sonra dizi içerisindeki elemanların toplamarını ve ortalamasını ekrana yazdıran bir uygulama yazalım.

            int kullDeger = 0, toplam = 0, ortalama = 0;


            Console.Write("Lütfen dizi eleman sayısını belirtiniz: ");
            kullDeger = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[kullDeger];

            for (int i = 0; i < kullDeger; i++)
            {
                Console.Write("Lütfen {0}. indeks elemanını giriniz: ", i);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int item in sayilar)
            {
                toplam = toplam + item;
            }

            ortalama = toplam / kullDeger;

            Console.WriteLine("Girmiş olduğunuz değerler toplamı: {0}. Ortalaması: {1}.", toplam, ortalama);

            Console.ReadLine();


            #endregion
            #region Uygulama 2 : 20 elemanlı bir int dizi oluşturalım. Değerlerimizi random sınıfının next fonksiyonu ile 1 - 10 arasındaki değerler ile dolduralım. Daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde kaç tane 4 değeri olduğunu bulalım. 

            int sistemUretSayi = 0, sayac2 = 0;

            int[] sayilar2 = new int[20];

            Random Rnd = new Random();                            // Bunu for döngüsünde yazmamamızın sebebi aynı rakamı vermesin diye.
                                                                  // Random sınıfı, varsayılan olarak sistem saatine (örneğim milisaniye 
            for (int j = 0; j < 20; j++)                          // cinsinden) dayalı bir tohum kullanır. Döngü çok hızlı çalıştığı için 
            {                                                     // her yeni Random nesnesi, aynı sistem saati değerine denk gelebilir. Bu
                sistemUretSayi = Rnd.Next(1, 10);                 // durumda, her iterasyon aynı rastgele sayı dizisini üretebilir. Çözüm:
                sayilar2[j] = sistemUretSayi;                     // Random nesnesini döngü dışında tanımlarsanız, tohum bir kez 
            }                                                     // oluşturulur ve döngü boyunca aynı Random nesnesi kullanılarak farklı 
            foreach (int item in sayilar2)                        // sayılar üretilir.
            {
                Console.WriteLine(item);
                if (item == 4)
                {
                    sayac2++;
                }

            }
            Console.WriteLine("Dizi içerisindeki 4 sayısı {0} defa kullanılmıştır", sayac2);
            Console.ReadLine();
            #endregion


        }
    }
}
