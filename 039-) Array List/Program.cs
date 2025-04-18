using System;
using System.Collections;
using System.Collections.Generic;                          //  Bu kutuphane eklenmeden Array List kullanilamaz!!!
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039___Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {   //  using System.Collections.Generic;  kutuphanesi eklenmeden Array List kullanilamaz!!!!!!!!!!!

            ArrayList koleksiyon = new ArrayList();        //  Oncelikle nesne olusturulmali ki ArrayList sinifina erisebilelim.

            koleksiyon.Add("Melih");
            koleksiyon.Add("Ezgi");
            koleksiyon.Add("Panduf");
            koleksiyon.Add("Defne");
            koleksiyon.Add("Melih");                       //  Ayni degerden birden fazla ekleyebilirsin.
            koleksiyon.Remove("Melih");                    //  ilk tanimlanan Melih degerini sildi.

            int count = koleksiyon.Count;                  //  Array Listín eleman sayisini dondurur.
            //koleksiyon.Clear();                          //  Array Listin icini tamamen temizler.
            koleksiyon.Insert(2, "Simba");                 //  Ikinci indekse Simba degerini ekle demek.
            //koleksiyon.Reverse();                        //  Dizimizikomple ters cevirir.
            

            foreach (var a in koleksiyon)                  //  var kullanmamizin sebebi turu gorup kendi otomatik belirlesin diye.
            {
                Console.WriteLine(a);
            }
            
            Console.WriteLine(count);
            Console.WriteLine(koleksiyon.Contains("Defne"));//  Array Listin icinde var mi kontrolu yapar. Varsa True dondurur.
            Console.WriteLine(koleksiyon.IndexOf("Panduf"));//  Cikti = 1 cunku ilk Melih degeri silinmisti onceki satirlarda. Eger ki deger yoksa -1 doner.
            Console.ReadLine();

            ArrayList rakamlar = new ArrayList();

            rakamlar.Add(5);
            rakamlar.Add(3);
            rakamlar.Add(1);
            rakamlar.Add(100);
            rakamlar.Add(2);

            rakamlar.Sort();                               //  ArrayListí kucukten buyuge siralar.

            foreach (var a in rakamlar)                  
            {
                Console.WriteLine(a);                      //  Cikti: 1,2,3,5,100
            }

            Console.ReadLine();




        }
    }
}
