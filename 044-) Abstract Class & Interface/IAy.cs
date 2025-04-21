using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044___Abstract_Class___Interface
{
    public interface IAy                                   //  Bunu kullanisli olmadigi icin bu projede abstract olarak kullandik Interfaceí tercih etmedik. Cunku gunSaati metodu her ay icin ayni sonuc ve her ay icin bos yere tek tek calisiyor. Bizim bunu sabit yapmamiz gerekli.
    {
        int gunSaati();
        int kacGundenOlusur();
        int yilinKacinciAyi();
        

    }
}
