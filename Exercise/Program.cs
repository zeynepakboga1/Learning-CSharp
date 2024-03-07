using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 Ad soyad bilgisi yazdirma 
            string ad;
            Console.Write("Adınızı Giriniz: ");
            ad = Console.ReadLine();
            string soyad;
            Console.Write("Soyadınızı giriniz: ");
            soyad = Console.ReadLine();

            // 2 KDV Hesaplama(% 18)
            //fiyat*(1+KDV oranı)
            
           double sonuc;
            int fiyat;
            Double KDV = 0.18;


            Console.WriteLine("Ürünün fiyatını giriniz: "  );
            fiyat = Convert.ToInt32(Console.ReadLine());
            sonuc = (fiyat * (1 + KDV));
            Console.WriteLine( sonuc);
            Console.ReadLine();
            // Girilen sayının pozitif ya da negatif olma durumu 
          
            double sayi;
            Console.WriteLine("Bir sayı giriniz: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            if (sayi < 0)
                Console.WriteLine("Girmiş olduğunuz sayı negatiftir");
            if (sayi> 0)
             Console.WriteLine("Girrmiş olduğunuz sayi pozitiftir");
            Console.ReadKey();

            



        }

    }
}
