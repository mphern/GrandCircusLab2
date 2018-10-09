using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string goAgain;
            do
            {
                double width;
                double length;
                Console.Write("Enter Width (in feet): ");
                while(!(double.TryParse(Console.ReadLine(), out width)) || width <= 0)
                {
                    Console.WriteLine("Invalid input. Enter Width (in feet): ");
                }
                Console.Write("Enter Length (in feet): ");
                while (!(double.TryParse(Console.ReadLine(), out length)) || length <= 0)
                {
                    Console.WriteLine("Invalid input. Enter Length (in feet): ");
                }
                double perimeter = (2 * width) + (2 * length);
                double area = width * length;
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("\n");
                Console.Write("Would you like to continue? Y/N: ");
                goAgain = Console.ReadLine().ToUpper();
                while(goAgain != "Y" && goAgain != "N")
                {
                    Console.Write("Invalid Input. Would you like to continue? Y/N: ");
                    goAgain = Console.ReadLine().ToUpper();
                }
                Console.WriteLine("\n");
            } while (goAgain == "Y");
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
