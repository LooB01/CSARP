using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorAlistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Merhaba : 
             * İsminiz : 
             * Soyisminiz : 
             * Doğum yılınız : 
             * 
             * 
             * Ekran Temizle
             * 
             * 
             * Merhaba Muhammet Karagülle 18 yaşındasınız
             * 
             * 
             * 
             * 
             * 
            */

            Console.WriteLine("Merhaba , ");

            Console.Write("İsminiz : ");
            string isim = Console.ReadLine();


            Console.Write("Soyisminiz : ");
            string soyisim = Console.ReadLine();


            Console.Write("Doğum Yılınız : ");
            string yılstr = Console.ReadLine();


            Console.Clear();


            int yil = Convert.ToInt32(yılstr); // burda string olan yılstr int çevriliyor
            //int mevcutyil2 = 2022; 
            int mevcutyil2 = DateTime.Now.Year;
            int yas = mevcutyil2 - yil;

            string mesaj = "Merhaba " + isim + " " + soyisim + " " + yas + "  yaşındasınız...";
            Console.WriteLine(mesaj);
            Console.ReadLine(); 

        }
    }
}
