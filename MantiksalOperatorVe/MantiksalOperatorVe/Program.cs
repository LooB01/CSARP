using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantiksalOperatorVe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mantıksal ve Operatörü && 
            // bool donendeger = degisken == "admin" && degisken2 == "123" True 
            /* 
             * 
             * 
             * 
             * degisken1            Degisken 2           sonuc 
             * True                 True                 True
             * False                True                 False
             * True                 False                False 
             * False                False                False
             * 
             * 
             * 
             * 
             * 
             * 
             */

            string kullaniciadi = "admin";
            string sifre = "123";
            string anahtar = "1";


            bool donendeger = kullaniciadi == "admin" && sifre == "123";
        //  bool donendeger = kullaniciadi == "admin" && sifre == "123" && anahtar == "1";






        }
    }
}
