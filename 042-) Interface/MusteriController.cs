using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042___Interface
{
    public class MusteriController
    {
        public void musteriEkle(IMusteri veritabani)       //  Burada musteriEkle metotunda parametre olarak IMusteri verilerek tek bir komutta ekle isini yapacak tum classlari yazmis olduk. Interface kullanmasaydik eger her class icin tek tek musteri ekle yazacaktik.
        {
            veritabani.ekle();
        }
        public void musteriSil(IMusteri veritabani)
        {
            veritabani.sil();
        }
        
    }
}
