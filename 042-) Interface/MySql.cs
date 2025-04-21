using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042___Interface
{
    public class MySql : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("Mysql eklendi");
        }

        public void guncelle()
        {
            Console.WriteLine("Mysql guncelledi");
        }

        public void sil()
        {
            Console.WriteLine("Mysql sildi");
        }
    }
}
