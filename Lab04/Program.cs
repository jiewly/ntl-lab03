using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input number A Operation(+,-,*,/) B ");
            Console.WriteLine("------------------------- ");

            Console.Write("Input number A : ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input number B : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input operation (+,-,*,/) : ");
            var mathematical = Console.ReadLine();

            var operationcal = new Operation(num1, num2, mathematical);

            var result = operationcal.Execute();

            Console.WriteLine("Summary: " + result);
            Console.ReadLine();
        }
    }
}