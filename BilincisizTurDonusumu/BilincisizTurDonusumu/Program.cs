using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilincisizTurDonusumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bilinçsiz Tür Dönüşümü

            int sayi1 = 255;
            int intMin = int.MinValue;
            int intMax = int.MaxValue;

            byte sayi2 = (byte)sayi1; // Bilinçsiz tür dönüşümü 
            byte sayi3 = 100;

            int sayi4 = sayi3;  // Bilinçli tür dönüşümü 

            Console.WriteLine(sayi4);

        }
    }
}
