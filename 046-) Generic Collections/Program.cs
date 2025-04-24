using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046___Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {   //  Tip guvenligi vardir. Hangi tipte olusturulduysa sadece o tipte eleman kabul eder.

            List<int> rakamlar = new List<int>();          //  List int tipinde rakamlar adinda degisken olusturup, int tipinde List nesnesini atiyoruz.

            rakamlar.Add(0);
            //  rakamlar.Add("0");           HATA verir. Cunku sadece int kabul eder.

            
            
            
            
            //-------------------------------------------------------------------------------------------------------------------------

            List<Musteri> musteriler = new List<Musteri>();//  Musteri sinifi turunde List tipinde musteriler adinda degisken tanimliyorruz ve Musteriler turunde List nesnesini buna tiyoruz.
            musteriler.Add(new Musteri(1, "Melih", "Diler", "dilermelih@gmail.com"));//musteriler degiskeni Musteri turunde tanimlandigi icin icine Musteri sinifi turunde 
            musteriler.Add(new Musteri(2, "Ezgi", "Diler", "dilerezgi@gmail.com"));  //deger atabiliriz. Bu sebeple degerden ziyade nesne atmamiz gerekir nesne tanimlayarak 
            musteriler.Add(new Musteri(3, "Panduf", "Diler", "dilerpanduf@gmail.com"));//degerleri atadik. Nesneleri asagida tek tek olusturup atadigimiz degiskenleri de 
                                                                                       //buraya parantez icine yazabilirdik.
            foreach (Musteri musteri in musteriler)   //  musteriler generic listesi icinde her gezdigimiz nesne degerini Musteri sinifi tipindeki musteri degiskenine atiyoruz.
            {
                Console.WriteLine(musteri);
            }

            Console.ReadLine();

            
        }
    }
}
