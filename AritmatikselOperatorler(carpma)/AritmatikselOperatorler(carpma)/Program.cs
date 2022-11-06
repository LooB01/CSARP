using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorler_carpma_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // çarpma
            // *  

            // byte int double float decimal 

            double d1 = 10.4;
            double d2 = 10;
            double sonuc = d1 * d2;

            // Kısa hali
            int sonucint2 = (int)(d1 * d2);
            
            Console.WriteLine(sonucint2);
            
            // Uzun hali
            double sonucDouble = d1 * d2;
            sonucint2 = (int)sonucDouble; 
            
            Console.WriteLine(sonucint2);
            Console.ReadLine(); 


            

        }
    }
}
