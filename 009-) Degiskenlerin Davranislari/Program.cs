using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009___Degiskenlerin_Davranislari
{
    internal class Program
    {
        static void Main(string[] args)
        {

                                                           //////////*** DEGISKENLERIN DAVRANISLARI ***\\\\\\\\\\ 

            string degiskenVal1 = "Melih Diler";
            string degiskenVal2 = "Ezgi Diler";

            degiskenVal1 = degiskenVal2;      // Burada Val2'deki değeri Val1'e kopyalar. Güncel olarak sürekli oradan değer almaz.
                                              // Val2 değiştikçe Val1 güncellenmez.
            degiskenVal2 = "Panduf Diler";    // Val1 hala "Ezgi Diler" dir.  


            //  Değer Tipli = Ramin STACK kısmında depolanır.
            //  Referans Tipli = Ramin HEAP kısmında depolanır.

            //  Deger tipli        =  int, double, bool, char, struct, enum
            //  Referans tipli     =  string, array, class, interface, delegate, object, List<T>

            //  Değer tipli degiskenler değeri verir ve arasında hiçbir bağ yoktur. Değerlerinin eşit olup olmadıklarına bakar.
            //  Referans tipler ise değerlerinin eşitliklerine değil baktıkları yerlerin aynı olup olmadıklarına bakar.

            int a = 3;  //  Stack kisimda yer alir.
            int b = 3;  //  Stack kisimda yer alir.
            int c = a;  //  Stack kisimda yer alir. Burada a degiskeninde hangi deger varsa aynisini ata demek. Ilerde a degisirse c degismez. a = b ve a = c 


            new Ornek();//  Burada HEAP kisminda Ornek sinifindan bir nesne olusturuluyor. Eger ki bir sure boyunca referanssiz nesne olarak kalirsa yani degiskensiz, Garbage Collector bunu siler ve sen sonra yazsan bile bulunmaz.
            Ornek abc;  //  Burada Ornek class tipinde abc adinda bir degisken tanimlaniyor.
            abc = new Ornek();  //  Burada da new ile Ornek tipinde nesne olusturuluyor. Tek satir hali:  Ornek abc = new Ornek();

            //--------------------------------------------------------------------------------------------------------------------------

            Ornek x = new Ornek();
            Ornek y = x;              //  Burada diyoruz ki xín HEAP'de baktigi yere y'de baksin. Bu durumda nerede olursa olsun x veya y degisirse digeride degisir. Cunku baktiklari yeri degistiriyoruz.

        }

        
    }
}
