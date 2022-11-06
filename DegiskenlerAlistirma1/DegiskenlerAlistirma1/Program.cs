using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenlerAlistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("merhaba");

            Console.Write("İsminiz nedir ?: ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminiz nedir ?: ");
            string soyisim = Console.ReadLine();

            Console.Write("Yaşadığınız şehri giriniz ?: ");
            string sehir = Console.ReadLine();

            Console.Write("Yaşınız ? :");
            string yas = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("İsim : " + isim); // İsim : Cengiz
            Console.WriteLine("Soyisim : " + soyisim);
            Console.WriteLine("Memleket : "+ sehir);
            Console.WriteLine("yaşınız : " + yas);
            Console.WriteLine(":d");

            Console.ReadLine();



            
        }
    }
}
