using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            add2(20,30);
            int result = add2(20, 30);
            Console.WriteLine(result);
            Add3(10, 20);
            int ekle = Add3(10, 20);
            Console.WriteLine(ekle);
           

            Console.ReadLine();


        }

        static void Add()
        {
            Console.WriteLine("added!!");

        }
        //Working with parameterized methods
        static int add2(int num1,int num2)
        {
            int result = (num1 + num2);
            return result;

        }
        //Working with methods with default parameters
        static int Add3(int a,int b,int c=20)
        {
            int ekle = (a + b + c);
            return ekle;

        }
        




       



    }

}
