
namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args) {

            System.Console.WriteLine("\n\nEnter Q to quit.");
            double squareroot;
            bool cont = true;

            while (cont) {
                System.Console.Write("\nEnter a number to calculate its squareroot: ");
                string input = System.Console.ReadLine();
                if (input == "Q")
                    cont = false;
                else if (double.TryParse(input, out double inumb)) {
                    if (inumb < 0) {
                        inumb *= -1;
                        squareroot = System.Math.Sqrt(inumb);
                        System.Console.WriteLine($"The squareroot of the number {inumb:F3} is {squareroot:F3}i");
                    } else {
                        squareroot = System.Math.Sqrt(inumb);
                        System.Console.WriteLine($"The squareroot of the number {inumb:F3} is {squareroot:F3} ");
                    }
                } else System.Console.WriteLine("\nINVALID INPUT!!!");

            }
        }
    }
}
