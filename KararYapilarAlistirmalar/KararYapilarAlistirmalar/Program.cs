using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilarAlistirmalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adınızı giriniz :");
            string kullanıcıAdi = Console.ReadLine();


            Console.Write("Şifrenizi giriniz :");
    
            string sifre = Console.ReadLine();  




            // Kullanıcı adı : admin
            // Şifre : 123 


            if(kullanıcıAdi == "admin" & sifre == "123")
            {

                Console.WriteLine("Merhaba Girişiniz başarılı");



            }
            else
            {

                Console.WriteLine("Giriş başarısız, Kullanıcı adı veya şifrenizi kontrol ediniz");


            }

            Console.ReadLine();

        }
    }
}
