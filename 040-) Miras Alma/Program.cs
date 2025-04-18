using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040___Miras_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Kedi sinifi hayvan sinifindan miras aldigi icin kedi sinifi uzerinden hayvan sinifi bilgilerine ulastik ve metotlarini calistirabildik.

            Kedi kedi1 = new Kedi();
            kedi1.hayvan_isim = "Boncuk";
            kedi1.hayvan_cinsiyet = "Disi";
            kedi1.hayvan_rengi = "Beyaz";

            kedi1.hayvanBilgisiGoster();

            Console.ReadLine();


        }
    }
}
