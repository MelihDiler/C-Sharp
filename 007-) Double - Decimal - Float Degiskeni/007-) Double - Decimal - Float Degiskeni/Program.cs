using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007___Double___Decimal___Float_Degiskeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                              //////////*** DECIMAL ***\\\\\\\\\\


            decimal decimalVal1 = 10.2M;     // Sonunda m koymak zorundayiz. Ondalıklı sayıları aldığı gibi tam sayıları da alabilir.
            decimal decimalVal2 = 10.3m;     // Sayıları ondalıkı verirken virgül ile değil nokta ile vermen gerekir.

            decimal decimalMinVal = decimal.MinValue;  // -79228162514264337593543950335
            decimal decimalMaxVal = decimal.MaxValue;  // 79228162514264337593543950335
            Console.WriteLine(decimalMinVal);

                                               //////////*** DOUBLE ***\\\\\\\\\\


            double doubleVal1 = 10;          // Ondalıklı sayıları aldığı gibi tam sayıları da alabilir.
            double doubleVal2 = 10.2;        // Sayıları ondalıkı verirken virgül ile değil nokta ile vermen gerekir.
            double doubleVal3 = 10.9d;       // Sonuna d koymak zorunda değiliz ama Decimal'de "m", Float'ta "f" koymak zorundayız. 
            double doubleMinVal = double.MinValue;  // -1,79769313486232E+308
            double doubleMaxVal = double.MaxValue;  // 1,79769313486232E+308
            Console.WriteLine(doubleMinVal);



                                                //////////*** FLOAT ***\\\\\\\\\\


            float floatVal1 = 10.2F;

            float floatMinVal = float.MinValue;  // -3,402823E+38
            float floatMaxVal = float.MaxValue;  // 3,402823E+38
            Console.WriteLine(floatMinVal);

            // Bazı yazılım dillerinde decimal veya double olmayabiliyor. O yüzden bu çeşitliliği kullanman gerekebiliyor.
            // FLOAT < DOUBLE < DECIMAL
            Console.ReadLine();


        }
    }
}
