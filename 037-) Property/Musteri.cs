using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037___Property
{
    public class Musteri
    {

        private int kilo;

        public int KILO                                    //  prop TAB TAB  ile kisayoldan olusturulabilir.
        {
            get 
            {
                return kilo;
            }
            set 
            {
                kilo = value;                              //  value = Program sayfasinda atadigim degerdir.
            }
        }


    }
}
