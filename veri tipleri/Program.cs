using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            char character = 'd';
            Console.WriteLine(character);
            Console.WriteLine("character is {0}",(int) character);
            bool condition = false;
            int number1 = 80;
            long number2 = 30000000000;
            short number3 = 1200;
            byte number4 = 0;


            Console.WriteLine();

            Console.WriteLine(number4);
            Console.WriteLine("numer4 is {0}", number4);
            Console.WriteLine(number1);
            Console.WriteLine("number1 is {0}",number1);
            Console.WriteLine(number2);
            Console.WriteLine("number2 is{0}",number2);
            Console.WriteLine(number3);
            Console.WriteLine("number3 is{0}", number3);
           

            Console.ReadLine();



        }
    }
}
