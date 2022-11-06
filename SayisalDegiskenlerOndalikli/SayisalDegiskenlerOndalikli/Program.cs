using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayisalDegiskenlerOndalikli
{
    internal class Program
    {
        private const double maxValue = double.MaxValue;

        static void Main(string[] args)
        {
            // Double

            double doubleval1 = 10.2;
            double doubleval2 = 10;
            double doubleval13 = 10.9d;
            

            double doubleMinVal = double.MinValue;
            double doublemaxval = double.MaxValue;

            Console.WriteLine(doubleMinVal);
            Console.WriteLine(doublemaxval);



            // Decimal
            decimal decimalval1 = 10.2M;

            decimal decimalMinVal = decimal.MinValue;
            decimal decimalMaxVal = decimal.MaxValue;

            Console.WriteLine(decimalMaxVal);
            Console.WriteLine(decimalMinVal);


            // Float

            float floatVal1 = 10.2F;

            float floatMinVal = float.MinValue; 
            float floatMaxVal = float.MaxValue;
            
            Console.ReadLine();
            decimal decimal1 = 3;

            float floatval1 = (float) decimal1;





        }
    }
}
