using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042___Interface
{
    public class SqlServer : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("sql server eklendi");
        }

        public void guncelle()
        {
            Console.WriteLine("sql server guncelledi");
        }

        public void sil()
        {
            Console.WriteLine("sql server sildi");
        }
    }
}
