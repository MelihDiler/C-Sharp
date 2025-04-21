using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044___Abstract_Class___Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ocak ocak = new Ocak();
            Console.WriteLine("Ocak gun saati : " + ocak.gunSaati());     //  Ocak sinifi Ay sinifindan miras aldigi icin Ay sinifinda yazan metoda ulasabildik.

            Subat subat = new Subat();
            Console.WriteLine("Subat gun saati : " + subat.gunSaati());

            Mart mart = new Mart();
            Console.WriteLine("Mart gun saati : " + mart.gunSaati());

            Console.ReadLine();
        }
    }
}
