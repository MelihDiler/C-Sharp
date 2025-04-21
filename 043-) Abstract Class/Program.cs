using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043___Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  TemelSinif temelsinif = new TemelSinif();  absract siniftan nesne olusturamazsin ve haliyle icindekilerede ulasamazsin. Amac tüm alt sınıflar için ortak bir şablon ve bazı kurallar oluşturmak için kullanılır.
            AltSinif altsinif = new AltSinif();
            altsinif.metot1();
            altsinif.metot2();

            Console.ReadLine();

        }
    }
}
