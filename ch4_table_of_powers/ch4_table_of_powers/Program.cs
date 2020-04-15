using System;

namespace ch4_table_of_powers {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to the Squares and Cubes table");

            int number;
            int squared;
            int cubed;
            string choice = "y";
            int i = 1;

            while (!choice.Contains("n")) { 
            Console.WriteLine("Enter an integer: ");
            number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Number  Squared  Cubed");
                Console.WriteLine("======  =======  =====");


                for (i = 1; i <= number; i++) {
                    squared = i * i;
                    cubed = i * i * i;

                    Console.WriteLine(i + "\t" + squared + "  " + "\t" + cubed);

                }

                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();

            }
            Console.WriteLine("Bye");
        }




    }
}
