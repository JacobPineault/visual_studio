using System;

namespace ch3_Temperature_Converter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Welcome to the Temperature Converter: F -> C");

            double fTemp;
            string choice = "y";

            while (!choice.Contains("n")) { 
            Console.WriteLine("Enter degrees in Fahrenheit: ");
            fTemp = Convert.ToDouble(Console.ReadLine());

            GetCelsius(fTemp);

                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();

            }
            
        }

        private static void GetCelsius(double fTemp) {
            double cTemp = (fTemp - 32) * (double)((5.0 / 9.0));
            Console.WriteLine("Degrees in Celsius: " + cTemp);

        }
    }
}
