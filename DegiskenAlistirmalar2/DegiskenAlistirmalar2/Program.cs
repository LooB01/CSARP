using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenAlistirmalar2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Merhaba");
            Console.Write("İsminiz ? ");
            string isim = Console.ReadLine();

            Console.Write("Soyadınız ? ");
            string soyad = Console.ReadLine();

            Console.Write("Memleket ? ");
            string memleket = Console.ReadLine();

            
           Console.Write("Yaşınız ? ");
           string yas = Console.ReadLine(); 
            int yasparse = int.Parse(yas);
            int yasconvert = Convert.ToInt32(yas);

            Console.Clear();

            Console.WriteLine("İsim : "+ isim);
            Console.WriteLine("Soyadınız :"+ soyad);
            Console.WriteLine("Memleket :"+ memleket);
            Console.WriteLine("Yaş : " + yasconvert);

            Console.ReadLine();


            









        }
    }
}
