using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Static_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.PI); // The constant PI
            Console.WriteLine(Math.E); // Represents the natural logarithmic base e
            int x = 1;                       
            double a = 10.6;
            int y = 2;
            int z = 45;
            int Pierwiastek = 25;
            int wartoscBezwgledna = ~10;   
            Console.WriteLine(Math.Max(x,y));                 // Return the larger of its two arguments
            Console.WriteLine(Math.Min(x, y));               // Return the smaller of its two arguments
            Console.WriteLine(Math.Abs(wartoscBezwgledna)); // Return the absolute value of its arguments
            Console.WriteLine(Math.Sin(z));                // Return the Sine of the specified angle
            Console.WriteLine(Math.Cos(z));               // Return the Cosine of the specified angle
            Console.WriteLine(Math.Pow(z, y));           // Return a specified number raised to the specified power
            Console.WriteLine(Math.Round(a));           // Rounds the decimal number to its nearest integral value
            Console.WriteLine(Math.Sqrt(Pierwiastek)); // Return the square root of a specified number

            /*
              
            Array
            
            The Array class includes some static methods for manipulating arrays:
            */
            int[] firstArray = {1, 2, 3, 4};
            Console.WriteLine($"Here The foreach loop start");
            foreach(int s in firstArray)
            {
                Console.Write(s);                                       // Write All Contents our Array 'firsArray'
            }
            Console.WriteLine();                                      // Make somethings as ENTER
            Array.Reverse(firstArray);                               // Reverse All Content in our Array 'firsArray'
            foreach(int s in firstArray)
            {
                Console.Write(s);                                  // Write All Contents our Array 'firsArray'
            }
            Console.WriteLine();
            Array.Sort(firstArray);                              // Sortign All Content our Array 'firstArray'
            foreach (int s in firstArray)
            {
                Console.WriteLine(s);                          // Write All Contents our Array 'firsArray'
            }
            
            
            
            // String;

            string firstString = "some text";
            string SecondString = "another text";

            String.Concat(firstString, SecondString);           // 

            String.Equals(firstString, SecondString);         // 


            // DateTime


            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.DaysInMonth(2018, 2));

            Console.ReadKey();
        }
    }
}
