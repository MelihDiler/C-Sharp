using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041___Cok_Bicimlilik___Polymorphsim
{
    public class Kare : Sekil
    {
        public int ekstraDeger = 10;
        public override void Ciz()                         //  override = miras aldigi siniftaki ayni isimli metotu ezebilir.
        {
            Console.WriteLine("Kare cizildi...");
        }
    }
}
