using System;

namespace ch5_guessing_game {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Guessing Game!");
            string choice = "y";


            while (!choice.Contains("n")) {
                Console.WriteLine("I'm thinking of anumber from 1 to 100.");
                Console.WriteLine("Try guessing it");





                Console.WriteLine("Try again? (y/n)");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Byee");
        }



    }
}
