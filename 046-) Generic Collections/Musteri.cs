using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046___Generic_Collections
{
    public class Musteri
    {
        private int id;
        private string isim;
        private string soyisim;
        private string email;

        public Musteri(int _id, string _isim, string _soyisim, string _email)
        {
            this.id = _id;
            this.isim = _isim;
            this.soyisim = _soyisim;
            this.email = _email;
        }

        public override string ToString()                  //  Bu kod icerdeki degerleri string tipinde vermemizi sagladi.
        {
            return $"ID: {id}, İsim: {isim}, Soyisim: {soyisim}, Email: {email}";
        }


    }
}
