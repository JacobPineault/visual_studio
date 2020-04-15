using System;

namespace ch3_interest_calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to the Interest Calculator");

            double loanAmount;
            double intRate;
            double interest;
            string choice = "y";

            while (!choice.Contains("n")) {

                Console.WriteLine("Enter loan amount: ");
                loanAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter interest rate: ");
                intRate = Convert.ToDouble(Console.ReadLine());

                interest = (loanAmount * intRate);

                Console.WriteLine(loanAmount.ToString("C"));
                Console.WriteLine(intRate.ToString("P3"));
                Console.WriteLine(interest.ToString("C"));

                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye");

        }
    }
}
