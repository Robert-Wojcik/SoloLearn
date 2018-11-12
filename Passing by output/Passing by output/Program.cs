using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passing_by_output
{
    class Program
    {
        static void Calc(int a, int b, out int sum, out int difference, out int product)
        {
            sum = a + b;
            difference = a - b;
            product = a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum, difference, product;

            Calc(num1, num2, out sum, out difference, out product);

            Console.WriteLine($"The sum of {num1} and {num2} is {sum}. The difference of {num1} and {num2} is {difference} ");

            Console.ReadKey();
        } 
    }
}
