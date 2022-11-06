using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisalVeyaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Veya Mantıksal Operatörü || 
            /*
             * 
             * Şart 1        Şart 2       Sonuc
             * 
             *  T             T           T 
             *  F             T           T 
             *  T             F           T   
             *  F             F           F  
             * 
             * 
             * 
             * 
             * 
             */


            string anahtar = "ASKDKASKDADAS2SA54ASD54SA";

            bool geriDonus = anahtar == "ASKDKASKDADAS2SA54ASD54SA" || anahtar == "ADSASDA54" || anahtar == "DSASAKDKAS44";



        }
    }
}
