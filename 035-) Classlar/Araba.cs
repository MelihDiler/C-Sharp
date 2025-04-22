using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035___Classlar
{// Dort cesit erisim belirleyicisi var: public -- private -- protected -- internal
 // Erişim Türü    Tanımlandığı Class  Türeyen Class   Dış Class
 // private	               ✅	             ❌	          ❌
 // protected	           ✅	             ✅	          ❌
 // internal	           ✅              	 ✅	          ✅ (aynı assembly)
 // public	               ✅             	 ✅	          ✅
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;


        //  Yapici metotdur. ctor tab tab ile otomatik olusturulur. class ismi ile ayni olmak zorundadir. Nesne olusturulunca ilk olarak otomatik calisir. Yapici metot static ise erisim belirleyicisi olmaz, parametre almaz ve ilk calisan yapici metot o dur. Ayrica birden fazla nesne uretilirse sadece ilkinde calisir digerlerinde calismaz.
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
