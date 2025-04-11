using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018___Aritmatiksel_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                //////////////////// OPERATORLER \\\\\\\\\\\\\\\\\\\\
                                           ///////////////////////////////*\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\  



                                                           //*****TOPLAMA OPERATORU*****\\

            // iki sayısal değer varsa toplama işlemi, en az 1 string varsa metin birleştirme gerçekleştirir.

            // int + int          (toplama işlemi yapar)
            // int + string       (string)
            // string + int       (string)
            // string + string    (string)

            int s1 = 2147483647;              // Int max 2147483647 değerini alabilir. Toplama sonuvu long bile yapsan işlem hatalı döner.
            int s2 = 2;                       // Sebebi s1 ile s2 yi önce bi yerde toplar ardından longa yazar. Yani iki inti int içinde 
            long toplamlong = s1 + s2;        // toplama işlemi yapmaya çalışır ve limitleri aştığı için yanlış veri döndürür.
            Console.WriteLine(toplamlong);    // Çözümü ise s1 ya da s2 yi long yapmak
            Console.ReadLine();

            byte s3 = 10;
            byte s4 = 1;
            //byte toplambyte = s3 + s4;      // Burada hata almamızın sebebi 2 adet byte değişkenini başka bir byte'a yazamazsın zaten
            //Console.WriteLine(toplambyte);  // kapasitesi ufak.
            Console.ReadLine();               // Çözümü toplambyte int olmalı.

            string metin1 = "Merhaba ";
            int s5 = 10;
            string metinstr1 = metin1 + s5;
            Console.WriteLine(metinstr1);     // Çıktı = Merhaba 10
            Console.ReadLine();





                                                           //*****ÇIKARTMA OPERATORU*****\\

            byte b1 = 100;
            byte b2 = 50;
            int sonuc1 = b1 - b2;             // Burada sonuç 50 olarak döner. sonuc1 byte olmamasının sebebi 50-100 yapabilme
                                              // ihtimaline karşı bir önlemdir. Çünkü byte (-) değer almaz.




                                                            //*****ÇARPMA OPERATORU*****\\

            double d1 = 99.400000;
            double d2 = 10.0;
            //int sonucInt = d1 * d2;         // Burası hata verir. Bilinç dönüşümlerde büyük küçüğe dönüşmez.
            //int sonucInt = (int)d1 * d2;    // Burada kefil olsan da kabul etmez. Çözümü aşağıdadır.
            int sonucInt = (int)(d1 * d2);    // Burada parantezin katkısı. Sayıyı çarparken inte değil de çarptıktan sonra inte çevirir.
            double sonucDouble = d1 * d2;     // Uzun hali
            int sonucInt2 = (int)sonucDouble;

            Console.WriteLine(sonucInt2);





                                                             //*****BÖLME OPERATORU*****\\

            int ints1 = 10;
            //int ints2 = 0;                    // Bölen "0" olamaz
            int ints2 = 2;
            int sonucBolme = ints1 / ints2;
            Console.WriteLine(sonucBolme);
            Console.ReadLine();



                                                           //*****MOD ALMA OPERATORU*****\\

            // Bölüm sonrası kalanı gösterir.
            int mod1 = 10;
            int mod2 = 2;
            int sonucMod = mod1 % mod2;    // Tam bölündüğü için sonuç "0"dır.


                                                            //***** (++) OPERATORU *****\\

            int s10 = 10;
            int operatorSonuc1 = s10++;     // İlk önce s10'u operatorSonuc1'e atar. Ardından s10'u 1 arttırır.
            int operatorSonuc2 = ++s10;     // İlk önce s10'u bir arttırır. Ardından arttırılmış halini operatorSonuc2'ye atar.



                                                            //***** (--) OPERATORU *****\\ 



            int s11 = 10;
            int operatorSonuc3 = s11--;    // İlk önce s11'i operatorSonuc3'e atar. Ardından s11'i 1 azaltır. 
            int operatorSonuc4 = --s11;    // İlk önce s11'i bir azaltır. Ardından azaltılmış halini operatorSonuc4'e atar.







        }
    }
}
