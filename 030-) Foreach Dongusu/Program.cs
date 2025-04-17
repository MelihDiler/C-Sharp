using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030___Foreach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                    ////////////////////FOREACH DONGUSU\\\\\\\\\\\\\\\\\\\\
                                               ////////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\ 

            // Örneğin bir müşteri bende kayıtlı mı diye aynı sql'de odluğu gibi sorgulama işlemini foreach ile yapıyoruz.


            string[] isimler = new[] { "Melih Diler", "Ezgi Diler", "Panduf Diler", "Defne Diler" };

            foreach (string item in isimler)  // isimler dizisinde sırayla tek tek gezerek item değişkenine atar. Her döngüde diziden 
            {                                 // bir adet değer alır ve console.WriteLine ile ekrana yazıp bir alt satıra geçer.
                Console.WriteLine(item);      // Ardından dizi içerisindeki sıradaki değeri alır tekrar aşağıdaki kodu çalıştırır. 
            }                                 // Kodumuz ekana yazdırma olduğu için ve elinde bir değer olduğu için ekrana elindekini yazar.
            Console.ReadLine();







        }
    }
}
