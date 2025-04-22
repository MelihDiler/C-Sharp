using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036___Kapsulleme
{
    public class Ogrenci
    {   //  Amac: isim degiskenimi herhangi biri mudahale edemesin diye. Mudahale etme yontemi de kapsulleme ile ekledik bunlarda setIsim getIsim. Mudahale edilecekse de belli sartlarda edilsin diye. ornegin banka hesabinda bakiye kismi atanacak. Burada 0'dan buyukse sarti koyarak yanlis atamanin onune gecilebilir. Ayrica arkada yaptigim kodlamalara ulasamaz.

        private string isim;

        //  SET metodunu deger atamak icin, GET metodunu degeri almak icin 
        public void setIsim(string _isim)                  
        {
            isim = _isim;
        }

        public string getIsim()
        {
            return isim;
        }
    }
}
