using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikselOperatorler2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Çıkartma operatör ( - )
            // byte , int , double , float , decimal Değişken tiplerinde çalışır

            int s1 = 100; 
            int s2 = 50;

            int sonuc = s1 - s2;
            Console.WriteLine(sonuc);


            byte b1 = 50;
            byte b2 = 100;

            int sonucbyte = b1 - b2;
            // var kullanıldında int olarak değişken tipine gider çünkü byte 0 - 255 değer tutabildi için var garanti olsun diye her türlü int e çevirir









        }
    }
}
