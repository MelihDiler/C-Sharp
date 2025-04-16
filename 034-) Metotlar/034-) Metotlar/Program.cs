using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034___Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            selamVer();
            toplamaYap(5,7);                                  //  Parametresiz cagiramazsin.
            int donenDeger = toplamaYap2(8, 8);
            Console.WriteLine(donenDeger);
            Console.ReadLine();
        }
        //  Metotlar Main icine yazilmaz. Sadece ufak kisa local metotlar yazilabilir ve static olamazlar.



        //---------------------------------------------------------------------------------------------------------------------------
        //                                       PARAMETRESIZ VOID METOTLAR
        //---------------------------------------------------------------------------------------------------------------------------
        static void selamVer()                             //  void = metodun hiçbir değer döndürmediğini belirtir.
        {
            Console.WriteLine("Selamlar :)");
            Console.ReadLine();
        }
        //---------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------
        //                                       PARAMETRELI VOID METOTLAR
        //---------------------------------------------------------------------------------------------------------------------------
        static void toplamaYap(int sayi1 , int sayi2)      //  void = metodun hiçbir değer döndürmediğini belirtir. Int tipinde sayi1 adinda 1. parametremizi tanimladik.
        {
            Console.WriteLine("Gonderilen sayilarin toplami :" + (sayi1 + sayi2));
            Console.ReadLine();
        }
        //---------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------
        //                                       PARAMETRELI METOTLAR
        //---------------------------------------------------------------------------------------------------------------------------
        static int toplamaYap2(int sayi1, int sayi2)       //  void = metodun int değer döndürecegini belirtir. Int tipinde sayi1 adinda 1. parametremizi tanimladik.
        {
            int sonuc = sayi1 + sayi2;

            return sonuc;                                  //  return anahtar kelimesinde sonraki kodlar calismaz!
        }
        //---------------------------------------------------------------------------------------------------------------------- -----
    }
}
