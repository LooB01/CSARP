using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Toplama Operatörü
            // + 
            // İnt + int ( Toplama işlemi yapar ) 

            int s1 = 10;
            int s2 = 15;
            int toplamİnt = s1 + s2;

            byte s3 = 10;
            byte s4 = 10;
            int toplamByte = s3 + s4;
            // byte toplamByte = s3 + s4;  Eğer s3 255 ise toplayamaz alabildiği değer sınırını geçer



            // string + int  ( string )

            string metin1 = "Merhaba ";
            int s5 = 10;
            string toplamstr1 = metin1 + s5;
            
            // int + string ( string ) 

            string toplamstr2 = s5 + metin1;

            //string + string ( string ) 

            string metin2 = "Dünya";
            string toplamastr3 = metin1 + metin2;
            Console.Write(toplamastr3);
            Console.ReadLine();




        }
    }
}
