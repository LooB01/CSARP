using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 
             *  switch(ifade)
             *  
             *  {
             *  case kontrol1 : 
             *      çalışacak olan işlemler
             *  break;
             *  case kontrol1 : 
             *      çalışacak olan işlemler
             *  break;
             *  default; 
             *      Çaşışacak olan işlemler 
             *  break;
             *  
             *  
             *  }
             * 
             * 
             * 
             * 
             * 
             * 
             */
            // Ocak şubat mart nisan ... Muhammet
            Console.Write("Hangi Ay :");
            string kullanicigelen = Console.ReadLine();

            switch(kullanicigelen)
            {
                case "Ocak":
                case "Nisan":
                    Console.WriteLine("01");
                    break;
                case "Şubat":
                    Console.WriteLine("02");
                    break;
                case "Mart":
                    Console.WriteLine("03");
                    break;  
                    default:
                    Console.WriteLine("Belirtilen değerlerin dışında bir değer girişi yaptınız");
                    break;
                    
                    

            }
                Console.ReadLine();





        }
    }
}
