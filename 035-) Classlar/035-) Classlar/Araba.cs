using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035___Classlar
{// Dort cesit erisim belirleyicisi var: public -- private -- protected -- internal
 // Public: Her yerden erisilir.
 // Private: Sadece tanımlandığı class içinde erişilebilir.
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;


        //  Yapici metotdur. ctor tab tab ile otomatik olusturulur. class ismi ile ayni olmak zorundadir. Nesne olusturulunca ilk olarak otomatik calisir.
        public Araba(int _kapiSayisi, string _arabaModel, string _arabaRengi)
        {
            kapiSayisi = _kapiSayisi;
            arabaModel = _arabaModel;
            arabaRengi = _arabaRengi;
        }

        public void motorCalistir()
        {
            Console.WriteLine("Motor Calisiyor...");
        }

        public void kapilariKilitle()
        {
            Console.WriteLine("Kapilar kilitleniyor...");
        }


    }
}
