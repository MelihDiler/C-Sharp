using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041___Cok_Bicimlilik___Polymorphsim
{
    public class Sekil
    {
        public virtual void Ciz()                          //  virtual = beni miras alan sinif ayni isimle yaptigi metot ile ezebilir.
        {
            Console.WriteLine("Sekil cizildi...");
        }
    }
}
