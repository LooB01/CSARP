using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayisalDegiskenlerTamSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte deger1 = 10;
            int deger2 = 100;


            byte byteminVal = byte.MinValue;
            byte byteMaxVal = byte.MaxValue;

            int intMinVal = int.MinValue;
            int intMaxVal = int.MaxValue;

            Console.WriteLine("Byte En düşük veri boyutu :  "+ byteminVal);
            Console.WriteLine("Byte En büyük veri boyutu : "+ byteMaxVal);
           
            Console.WriteLine("İnt en büyük veri boyutu : "+ intMaxVal);
            Console.WriteLine("İnt En düşük veri boyutu : "+ intMinVal);

            Console.ReadLine();




        }
    }
}
