using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)

        {//integer
            int[] sayi = new int[2];
            sayi[0] = 50;
            sayi[1] = 10;
            for (int a = 0; a < sayi.Length; a++)
            {
                Console.WriteLine(sayi[a]);
                Console.ReadLine();
            }
            //string
            string[] isimler = {"elif","ali" };
            Console.WriteLine(isimler[0]);
            Console.ReadLine();
            for (int i = 0; i < isimler.Length; i++) 
            {
                Console.WriteLine(isimler[i]);
                Console.ReadLine();
            }
            //char
            char[] karakter = { 'z', 'e', 'y' };
            for (int b = 0; b < karakter.Length; b++)
            { 
                Console.WriteLine(karakter[b]);
                Console.ReadLine();
          
            }
        
            Console.WriteLine(karakter[1]);
            Console.ReadLine();

            //dizinin elemanlarını kullanıcıdan alma ve ekrana yazdırma
            int[] sayilar = new int[3];
           
            for (int c = 0; c < sayilar.Length; c++)
            {
                Console.WriteLine(  "sayilar dizisinin"+""+ (c+1) +""+". indexini giriniz");
                sayilar[c] = Convert.ToInt32(Console.ReadLine());
            }
            







        }




    } 
        

}
