using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            string islem;
            string sonuç;

            
            Console.WriteLine("bir sayi giriniz =");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bir sayi giriniz = ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("işlem seçin(+,-,*,/)");
            islem = Console.ReadLine();

            if (islem == "+")
                Console.WriteLine( sayi1 + sayi2);
                
            if (islem == "-")
                Console.WriteLine(sayi1 - sayi2);
            if (islem == "*")
                Console.WriteLine(sayi1 * sayi2);
            if (islem == "/")
                Console.WriteLine(sayi1 / sayi2);

                sonuç = Console.ReadLine();



        }
    }
}
