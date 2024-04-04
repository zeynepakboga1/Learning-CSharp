using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_While
{
    internal class Program
    {
        static void Main(string[] args)
        {//kulanıcının klavyeden girdiği isim ekranda yüz kez tekrarlanacaktır.
         //while ile
            string isim;
            Console.WriteLine( "lütfen isminizi giriniz");
            isim = Console.ReadLine();
            int i = 0;
            while (i < 100)
            {
                Console.WriteLine( (i+1)+isim);
                i++;
            }

            Console.ReadLine();
            //for ile 





        }
    }
}
