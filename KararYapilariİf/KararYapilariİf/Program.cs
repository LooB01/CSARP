﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariİf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
             * &&
             * ||
             * 
             * 
             * 
             * 
             */


            /*
             * 
             * if(şart/Şartlar (&&  ||)
             * 
             * {
             * 
             *            // Eğer şart veya şartlar sağlandı ise yapılacak işlemler
             * 
             * 
             * 
             * 
             * 
             * 
             * }
             *
             * 
             */

            /*
             * 
             * if (şart veya şartlar)
             * 
             *    {
             *    
             *  // şart veya şartlar doğru ise o zaman çalışacak kodlar
             *  }
             *  else if (şart veya şartlar)
             *  
             *  
             *  
             *  else 
             *  {
             *    // şart veya şartlar doğru değil ise o zaman çalışacak olan kodlar
             *    
             *  }
             * 
             * 
             */












            /*
            Console.Write("Sayı 1 değerini giriniz :");
            string sStr1 = Console.ReadLine();
            Console.Write("Sayı 2 değerini giriniz :");
            string sStr2 = Console.ReadLine();  

            decimal sayi1 = Convert.ToDecimal(sStr1);
            decimal sayi2 = Convert.ToDecimal(sStr2);
            decimal toplam = sayi1 + sayi2;

            //bool toplamKontrol = toplam > 50;
            //if(toplamKontrol)
            //{
            //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den büyük");

            //}

            if (toplam > 50)
            {

                Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den büyük");

               


            }
            
            */
            //if(toplam >50)
                        //{


                        //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den büyük");



                        //}

                        //else
                        // {


                        //    Console.WriteLine("Girmiş olduğunuz değerlerin toplamı 50 den küçük...");

                        //}














            Console.Write("Sayı 1 değerini giriniz :");
            string sStr1 = Console.ReadLine();
            Console.Write("Sayı 2 değerini giriniz :");
            string sStr2 = Console.ReadLine();

            decimal sayi1 = Convert.ToDecimal(sStr1);
            decimal sayi2 = Convert.ToDecimal(sStr2);
            decimal toplam = sayi1 + sayi2;


            

            if(toplam >= 100)
            {
                Console.WriteLine("Girilen değer 100 eşit veya büyük");





            }
            else if(toplam >= 50)
            {

                Console.WriteLine("Girilen değer 50 eşit veya büyük");




            }
            else
            {
                Console.WriteLine("Girilen değer 50 den küçük");





            }



            Console.ReadLine();

        }
    }
}
