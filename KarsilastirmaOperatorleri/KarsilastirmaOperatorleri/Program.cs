using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarsilastirmaOperatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int s1 = 50;
            int s2 = 100;
            
            
            // As Operatörü 

            string isimsoyisim = "Muhammet Karagülle";
            object objectString = isimsoyisim;
            string sonucstr = objectString as string;

            // Unboxing
            object o1 = s1; 
            s1 = (int)o1;
            Console.WriteLine(o1);
            
            // İs Operatoru 
            // bool donendeger = degisken is degiskentipi
            // İs kullanım amacı  verdiğimiz değişken tipi öylemi diye sordumuz bir kod 

            bool iskontrol = o1 is int; 
            bool iskontrol2 = o1 is byte;

            // s1 = (byte)o1; olmuyor

            

            

            // Küçük Eşit mi karşılaştırması 
            // Bool donendeger = degisken1 <= degisken2

            
            bool kucukesitsonuc = s1 <= s2; 



            // Büyük Eşit mi Karşılaştırması    
            // Bool donenDeger = degisken1 >= degisken2 

            bool buyukesit = s1 >= s2;



            // Atama Operatörü =
            // Değişken = AtanacakDeger

            decimal decimalsayi1 = 10.90M;


            // Eşit mi karşılaştırması Eşittir : == Eşit "değil mi?" : !=

            bool esitkontrol1 = s1 == s2;   
            bool esitkontrol2 = s1 != s2;   

            // Küçük mü karşılaştırması < 
            // Bool donusdegeri = degisken2 < degisken2 True False


            bool sonuckucuk = s1 < s2;  


            //  Büyük mü karşılaştırması >
            // Bool dönüşdeğeri = degisken1 > degisken2 False - True


            bool sonuc = s1 > s2;
            








        }
    }
}
