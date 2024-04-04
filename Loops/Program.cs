using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //birden ona kadar olan sayıları alt alta  ekrana yazdırma 
             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine(i);

             }
             Console.ReadLine();
             //birden ona kadar olan çift sayıları ekrana yazdurma
             for (int a = 0; a <= 10; a += 2)
             {
                 Console.WriteLine(a);
             }
             Console.ReadLine();
             //iç içe for döngüsü örnek 1
             for (int a = 1; a <= 5; a++)
             {
                 for (int b = 1; b <= a; b++) 
                 {
                     Console.Write(b);

                 }

                 Console.Write("");

               Console.ReadLine();
             }
             //iç içe for örnek 2
             for (int i = 1; i <= 5; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
                 Console.ReadLine();
             }
            
            //while döngüsü ile 1 den 100 1e kadar yazdırma
            int q = 1;
            while (q <= 100) 
            {
                Console.WriteLine(  q);
                q++;
                    
             
            }
            Console.ReadLine();
            //100 den geriye çifterli yazdırma
           int y = 100;
            while (y >= 0)
            {
                Console.WriteLine(y);
                y -= 2;
            }
            Console.ReadLine();
            //foreach döngüsü
            string harfler

        } 



}   }

