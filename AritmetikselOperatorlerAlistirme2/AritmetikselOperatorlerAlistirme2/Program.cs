using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikselOperatorlerAlistirme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayır 1 değerini giriniz :");
            string sayi1 = (Console.ReadLine());    
            
            Console.Write("Sayır 2 değerini giriniz :");
            string sayi2 = (Console.ReadLine());

            Console.Clear();

            decimal sayiI = Convert.ToDecimal(sayi1);
            decimal sayiII = Convert.ToDecimal(sayi2);

            decimal toplama = sayiI + sayiII;
            decimal cıkarma = sayiI - sayiII;
            decimal bölme = sayiI / sayiII;
            decimal carpma = sayiI * sayiII;
            decimal Mod = sayiI % sayiII;

            Console.WriteLine("Toplama :"+ toplama);
            Console.WriteLine("çıkarma :"+ cıkarma);
            Console.WriteLine("Bölme :"+ bölme);
            Console.WriteLine("Çarpma :"+ carpma);
            Console.WriteLine("Yüzde :"+ Mod);

            

            Console.ReadLine();
        }
    }
}
