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

                                             //////////*** DOUBLE ***\\\\\\\\\\
                                             
           
            double doubleVal1 = 10;          // Ondalıklı sayıları aldığı gibi tam sayıları da alabilir.
            double doubleVal2 = 10.2;        // Sayıları ondalıkı verirken virgül ile değil nokta ile vermen gerekir.
            double doubleVal3 = 10.9d;       // Sonuna d koymak zorunda değiliz ama Decimal'de "m", Float'ta "f" koymak zorundayız. 
            double doubleMinVal = double.MinValue;
            double doubleMaxVal = double.MaxValue;
            Console.WriteLine(doubleMaxVal);

                                             //////////*** DECIMAL ***\\\\\\\\\\


            decimal decimalVal1 = 10.2M;     
            decimal decimalVal2 = 10.3m;

            decimal decimalMinVal = decimal.MinValue;
            decimal decimalMaxVal = decimal.MaxValue;
            Console.WriteLine(decimalMaxVal);

                                              //////////*** FLOAT ***\\\\\\\\\\


            float floatVal1 = 10.2F;

            float floatMinVal = float.MinValue;
            float floatMaxVal = float.MaxValue;
            Console.WriteLine(floatMaxVal);

            // Bazı yazılım dillerinde decimal veya double olmayabiliyor. O yüzden bu çeşitliliği kullanman gerekebiliyor.
            // FLOAT < DOUBLE < DECIMAL
            Console.ReadLine();


        }
    }
}
