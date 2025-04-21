using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042___Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusteriController controller = new MusteriController();
            controller.musteriEkle(new SqlServer());
            controller.musteriEkle(new MySql());
            controller.musteriEkle(new Oracle());
            controller.musteriSil(new MySql());

            Console.ReadLine();
        }
    }
}
