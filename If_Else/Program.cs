using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {//number
            var number = 10;
            if (number == 10) ;
            Console.WriteLine("number is 10");
            //colour
            string colour = "red";
            if (colour == "blue")
                Console.WriteLine("colour is blue");
            else
                Console.WriteLine("colour is red");

            //single line if ile çalışmak
            var number2 = 30;
            Console.WriteLine(number2 == 20 ? "number is true" : "number is false");
            //
             
            Console.ReadLine();
        }
    }
}
