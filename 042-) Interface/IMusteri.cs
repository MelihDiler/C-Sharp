using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042___Interface
{
    public interface IMusteri
    {
        //  Erisim belirleyicisi veremezsin. Ayrica body yani {} olmaz. Amac tum metotlari yazip bir yerde goruntulemeyi saglar. Metotlarin ici olmadigi icin kalabaliklik yapmaz.

        void ekle();
        void sil();
        void guncelle();
    }
}
