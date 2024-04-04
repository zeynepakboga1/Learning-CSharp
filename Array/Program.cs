using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        //diziler
        {
            int[] sayilar = new int[3];
            sayilar[0] = 1;
            sayilar[1] = 5;
            sayilar[2] = 7;
            Console.WriteLine(sayilar[0]);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);


                //diğer veri tipleri ile dizi tanımlama
                //string double char
                string[] isimler = { "Merve", "Derin" };
                Console.WriteLine(isimler[0]);

            }
            Console.ReadLine();
        
     
    