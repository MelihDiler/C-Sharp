﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035___Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ClassIsmi referans_Isim = new ClassIsmi();
            Araba araba1 = new Araba(4, "Kirmizi", "Renault");//  Bu sekilde parametreli de verebiliriz. Ya da parametresiz verip asagida da tanimlayabilirsin. Parametreli temizdir

            //araba1.kapiSayisi = 4;
            //araba1.arabaRengi = "Kirmizi";
            //araba1.arabaModel = "Renault";

            araba1.kapilariKilitle();
            araba1.motorCalistir();

            Console.WriteLine("Araba kapi sayisi :" + araba1.kapiSayisi);
            Console.WriteLine("Araba rengi :" + araba1.arabaRengi);
            Console.WriteLine("Araba modeli :" + araba1.arabaModel);
            Console.ReadLine();




        }
    }
}
