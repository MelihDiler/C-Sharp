using System;
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





        }
    }
}
