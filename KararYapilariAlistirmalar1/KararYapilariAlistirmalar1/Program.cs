using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariAlistirmalar1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kullanıcı Kodunuz:");
            string kullaniciKodu = Console.ReadLine();
            kullaniciKodu = kullaniciKodu.ToUpper();


            if (kullaniciKodu == "ABC" || kullaniciKodu == "123" || kullaniciKodu == "236" || kullaniciKodu == "CMK")
            {
                Console.WriteLine("Kullanıcı girişiniz başarılı");



            }
            
            

            else if (kullaniciKodu == "HHH" || kullaniciKodu == "BBB" || kullaniciKodu == "MMM")
            {

                Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir, Devam etmek için enter'a basın");
                Console.ReadLine();
                Environment.Exit(0);




            }
            
            else 
            {

                Console.WriteLine("Hatalı kullanıcı kodu ");



            }


            Console.ReadLine(); 




        }
    }
}
