using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beden_Kitle_İndeksi
{
    internal class Program
    {
        static void Main(string[] args)
        /*beden kitle indeksi= kilo/boy*boy
         beden kitle indeksi 18'e eşit veya küçükse zayıf
        18 ile 25 arası normal
        25ten büyükse obez */
        {
         
            Console.WriteLine(  "lütfen kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(  "lütfen boyunuzu giriniz");
            double boy = Convert.ToDouble (Console.ReadLine());
            double sonuc = kilo / (boy * boy);
           
            if (sonuc <= 18)
            {
                Console.WriteLine("beden kitle indeksiniz =ZAYIF");
                Console.ReadLine();
            }
            else if (sonuc>18 && sonuc < 25)
            {
                Console.WriteLine(  "beden kitle indeksiniz =NORMAL");
                Console.ReadLine();
            }
            else if (sonuc>25)
            {
                Console.WriteLine("beden kitle indeksiniz =OBEZ");
                Console.ReadLine();
            }

        }
    }
}
