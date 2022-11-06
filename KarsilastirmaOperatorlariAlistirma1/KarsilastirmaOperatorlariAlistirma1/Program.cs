using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorlariAlistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. notu giriniz: ");
            string degerstr1 = Console.ReadLine();
            Console.Clear();
            Console.Write("2. notu giriniz: ");
            string degerstr2 = Console.ReadLine();
            Console.Clear();
            Console.Write("3. notu giriniz: ");
            string degerstr3 = Console.ReadLine();

            Console.Clear();

            decimal deger1 = Convert.ToDecimal(degerstr1);
            decimal deger2 = Convert.ToDecimal(degerstr2);
            decimal deger3 = Convert.ToDecimal(degerstr3);


            // Uzun Hali
            /*decimal toplam = deger1 + deger2 + deger3;
            decimal ortalama = toplam / 3; */
            
            decimal degerortalama = (deger1 + deger2 + deger3) / 3;

            /*
            bool esit = degerortalama == 45;
            bool buyukmu = degerortalama > 45;

            Console.WriteLine("Sınav ortalaman 45 değerinde eşit:  "+ esit);
            Console.WriteLine("Sınav ortalaman 45 den büyük: " + buyukmu);
            */

            bool degersonuc = degerortalama >= 45;
            Console.WriteLine("Ortalama değeriniz 45 değerinden Büyük veya eşit mi : "+ degersonuc);


            Console.ReadLine();




        }
    }
}
