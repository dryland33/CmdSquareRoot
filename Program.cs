using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("\n\nEnter Q to quit.");
            double squareroot;
            bool cont = true;

            while (cont) {
                Console.Write("\nEnter a number to get its squareroot: ");
                string input = Console.ReadLine();
                if (input == "Q")
                    cont = false;
                else if (double.TryParse(input, out double inumb)) {
                    if (inumb < 0) {
                        inumb *= -1;
                        squareroot = Math.Sqrt(inumb);
                        Console.WriteLine($"The squareroot of the number {inumb:F3} is {squareroot:F3}i");
                    } else {
                        squareroot = Math.Sqrt(inumb);
                        Console.WriteLine($"The squareroot of the number {inumb:F3} is {squareroot:F3} ");
                    }
                } else Console.WriteLine("\nINVALID INPUT!!!");

            }
        }
    }
}
