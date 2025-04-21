using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042___Interface
{
    public class Oracle : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("Oracle eklendi");
        }

        public void guncelle()
        {
            Console.WriteLine("Oracle guncelledi");
        }

        public void sil()
        {
            Console.WriteLine("Oracle sildi");
        }
    }
}
