using System;

namespace prj_2_3_RectangleCalculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello Nerd!");
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");

            String choice = "y";
            double length;
            double width;
            double area;
            double perimeter;

            while (choice.Contains("y")) { 
            Console.WriteLine("Enter length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            width = Convert.ToDouble(Console.ReadLine());

            area = length * width;
            perimeter = (2 * length) + (2 * width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();


            }
        }
    }
}
