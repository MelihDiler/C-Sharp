using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043___Abstract_Class
{
    public class AltSinif : TemelSinif                     //  tum absract metotlar implement edilmek zorundadir.
    {
        public override void metot2()                      //  absractlar metotlar override edilerek kullanilabilir.
        {
            Console.WriteLine("AltSinif calisti");
        }
    }
}
