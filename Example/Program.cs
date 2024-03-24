using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {//kullanıcıdan sayı alma alınan syıya kadar toplanıp o sayıya bolme 
         //çıkan işlem 50 den büyükse o büyüktür küçükse küçüktür
           
            Console.WriteLine("bir sayı giriniz ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for(int i=1; i <= sayi; i++)
            {
                toplam += i;
            }
            double ortalama = toplam / sayi;
            if(ortalama > 50)
            {
                Console.WriteLine( ortalama + "ortalamanız elliden büyüktür");
                Console.ReadLine();
            }
            else
                Console.WriteLine( ortalama + "ortalamanız elliden küçüktür");
            Console.ReadLine();

        }
    }
}
