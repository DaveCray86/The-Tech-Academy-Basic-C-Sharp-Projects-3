using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page117_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there User...");
            int s;
            RunCountdown(3, out s);
            Console.WriteLine(s);
            Console.ReadLine();

            Console.Write("Enter a dividend: ");
            int dividend = int.Parse(Console.ReadLine());
            Console.Write("Enter a divisor: ");
            int divisor = int.Parse(Console.ReadLine());
            int remainder;
            int result = Remainder(dividend, divisor, out remainder);

            Console.WriteLine("{0} / {1} = {2} with a remainder of {3}",
                dividend, divisor, result, remainder);
            Console.ReadLine();

            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius.");
            Console.Write(":");

            string selection = Console.ReadLine();
            double F, C = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the Celsius temp: ");
                    F = Class1.TempConvert.CelsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temp in Fahrenheit: {0:F2}", F);
                    break;

                case "2":
                    Console.Write("Please enter the Fahrenheit temp: ");
                    C = Class1.TempConvert.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine("Temp in Celsius: {0:F2}", C);
                    break;

                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        public static void RunCountdown(int n, out int i)
        {
            i = 0;

            for (int x = n; x > 0; x--)
            {
                Console.WriteLine(n);
                n = n - 1;
                i++;
            }
        }
        public static int square(int a, int b)
        {
            return a * b;
        }
        public static int Remainder(int dividend, int divisor, out int remainder)
        {
            remainder = dividend % divisor;
            return dividend / divisor;
        }
    }
}
