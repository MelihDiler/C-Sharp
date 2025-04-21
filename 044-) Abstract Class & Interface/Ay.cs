using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044___Abstract_Class___Interface
{
    public abstract class Ay
    {
        public int gunSaati()                              //  Bu metot tum aylarda ayni oldugu icin sabit tanimladik. Oteki turlu her ay icin bos yere tek tek calisacakti.
        {
            return 24;
        }

        public abstract int kacGundenOlusuyor();           //  Her ayda farkli olacagi icin bunu abstract olarak tanimladik.
        public abstract int yilinKacinciAyidir();          //  Her ayda farkli olacagi icin bunu abstract olarak tanimladik.
    }
}
