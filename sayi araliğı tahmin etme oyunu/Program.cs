using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_araliğı_tahmin_etme_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir numara giriniz: "); // Kullanıcıya bir mesaj yaz
            string numberstr = Console.ReadLine(); // Kullanıcıdan veri al ve numberstr değişkenine ata
            int number4 = int.Parse(numberstr); // numberstrssss'i int tipe dönüştür ve number4 değişkenine ata



            {
                if (number4 >= 0 && number4 <= 100)
                    Console.WriteLine("number is between 0-100");

                else if (number4 < 100 && number4 >= 200)

                    Console.WriteLine("number is between 101-200");
                else if (number4 < 0 || number4 > 200)
                    Console.WriteLine("number is less than 0 or greater than 200");
                
                Console.ReadLine();
            }
        }
    }
}
