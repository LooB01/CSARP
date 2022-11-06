using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikselOpertorlerOzelOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Mod alma opertörü % 
            int s1 = 11;
            int s2 = 2;
            int sonucmod = s1 % s2;

            // ++ operatörü 

            int s3 = 10;
            int Operatorsonuc1 = s3++; //Böyle olduğunda önce atama yapar yani Operatorsonuc1 e s3 10 değerini atar sonrasında s3 11 olur 
                                        
            int Operatorsonuc2 = ++s3; // Böyle olduğunda Operatorsonuc2 e 11 atar s3 ede 11 atar yani ++ yön belirler
            //int Operatorsonuc1 = s3 + 1;           


            //-- operatörü 

            int s4 = 10;
            int operatorsonuc3 = s4--;
            int operatorsonuc4 = --s4;  








        }
    }
}
