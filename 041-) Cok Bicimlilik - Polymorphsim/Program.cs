using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041___Cok_Bicimlilik___Polymorphsim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kare kare = new Kare();
            Daire daire = new Daire();
            Dortgen dortgen = new Dortgen();
            kare.Ciz();                                    //  Cikti : Kare cizildi... Sekil sinifindan miras aldi ama override ile ezdi ve kendi metodu calisti.
            daire.Ciz();                                   //  Cikti : Daire cizildi... Sekil sinifindan miras aldi ama override ile ezdi ve kendi metodu calisti.
            dortgen.Ciz();                                 //  Cikti : Sekil cizildi... Sekil sinifindan miras aldi ve Sekil sinifinin metodu calisti.

            Console.ReadLine();




        }
    }
}
