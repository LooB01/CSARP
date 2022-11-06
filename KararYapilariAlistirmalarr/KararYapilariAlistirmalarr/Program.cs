using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariAlistirmalarr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Menü 
             * 
             * 1 - Toplama
             * 2 - Çıkartma
             * 3 - çarpma
             * 4 - bölme 
             * Seçiniz 
             *
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */


            Console.WriteLine("Menü");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkartma");
            Console.WriteLine("3 - Çaprma");
            Console.WriteLine("4 - Bölme");
            Console.Write("Seçiniz: ");
            string kullanıcıSecim = Console.ReadLine();


            double d1 = 0;
            double d2 = 0;

            if (kullanıcıSecim == "1" || kullanıcıSecim == "2" || kullanıcıSecim == "3" || kullanıcıSecim == "4")
            {
                Console.Write("Sayı 1 değerini giriniz :");
                string s1 = Console.ReadLine();
                Console.Write("Sayı 2 değerini giriniz :");
                string s2 = Console.ReadLine();

                 d1 = Convert.ToDouble(s1);
                 d2 = Convert.ToDouble(s2);




            }


           


            if (kullanıcıSecim == "1")
            {

                double toplam = d1 + d2;
                Console.WriteLine("Toplam :" + toplam);




            }

            else if (kullanıcıSecim == "2")
            {

                double Cıkartma = d1 - d2;
                Console.WriteLine("Çıkartma: " + Cıkartma);

            }


            else if (kullanıcıSecim == "3")
            {
                double Carpma = d2 * d1;
                Console.WriteLine("Çarpma: " + Carpma);

            }

            else if (kullanıcıSecim == "4")
            {

                if (d2 == 0)
                {

                    Console.WriteLine("Bolen değer 0 olamaz...");



                }
                else
                {
                    Console.WriteLine("Değer dışı girdiniz. ");


                }


                double bolum = d1 / d2;
                Console.WriteLine("Bölme: " + bolum);

            }


            Console.ReadLine();




        }
    }
}
