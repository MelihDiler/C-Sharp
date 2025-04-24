using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047___Generic_Collection_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir object listesi oluşturuluyor (farklı türler eklenebilir). Ayrica hangi tipte (int'string'boolean vb.) eklersen ekle object olarak saklanir. Cikarkende object olarak cikar. Int degeri sayisal bir islemde kullanacaksan cikardiginda int'e cevirmen lazim.
            List<object> karisikListe = new List<object>();

            // Listeye farklı türde elemanlar ekleniyor
            karisikListe.Add(42);                // int
            karisikListe.Add("Merhaba Dünya");   // string
            karisikListe.Add(3.14);              // double
            karisikListe.Add(true);              // bool

            // Kendi sınıfımızdan bir nesne ekliyoruz
            Person p = new Person("Ahmet", "Yılmaz", 30);
            karisikListe.Add(p);                 // Buradaki p object turunde saklanir bu sebple geri cagirirken person tipine cevirmemiz gerekir.

            // Listeyi yazdırma
            foreach (object item in karisikListe)
            {
                if (item is Person)
                {
                    // Person nesnesi olduğunda özel yazdırma
                    Person person = (Person)item; // Yukarida anlatildigi uzere object tipinde saklanan degeri Person sinif turune cevirdik. Yoksa string olarak vericekti.
                    Console.WriteLine("Person: " + person);
                }
                else
                {
                    // Diğer türdeki elemanları genel olarak yazdır
                    Console.WriteLine("Diğer: " + item);
                }
            }

            Console.ReadLine();
        }
    }
}
