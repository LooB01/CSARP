using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorlariAlistirma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adınızı giriniz: ");
            string kullanıcıadi = Console.ReadLine();
            Console.Write("Şifrenizi Giriniz: ");
            string sifre = Console.ReadLine();
            Console.Clear();

            
            bool KullancıAdikontrol = kullanıcıadi == "admin";
            bool KullancıAdikontrol1 = kullanıcıadi != "admin";

            bool SifreKontrol = sifre == "123";
            bool SifreKontrol1 = sifre != "123";


            Console.WriteLine("Kullanıcı adı eşit mi :"+ KullancıAdikontrol);
            Console.WriteLine("Kullanıcı adı eşit değilmi :"+ KullancıAdikontrol1);

            Console.WriteLine("Şifre Eşit mi: " + SifreKontrol);
            Console.WriteLine("Şifre eşit değilmi: "+SifreKontrol1);

            Console.ReadLine();










        }
    }
}
