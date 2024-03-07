using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            if (number == 10) 
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

            //Working with if else block

            string name = "elif ece";
            if (name == "elif")
                Console.WriteLine("ELİF");
            else if (name == "elif ece")
                Console.WriteLine("ELİF ECE");
            else
                Console.WriteLine("ECE");

            //Working with switch block
            var number3 = 50;

            switch (number3)
            {
                case 20:
                    Console.WriteLine("number is 20");
                    break;
                case 40:
                    Console.WriteLine("number is 40");
                    break;
                default:
                    Console.WriteLine("number is 50");
                    break;
            }
            



            Console.ReadLine();

        }



            

        }





            
        }
    }

