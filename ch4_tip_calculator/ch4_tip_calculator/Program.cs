using System;

namespace ch4_tip_calculator {
    class Program {
        private static double tipAmount;
        private static double totalCost;

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Tip Calculator");

            double costOfMeal;
            double tipAmount;
            double totalCost;
            string choice = "y";

            while (!choice.Contains("n")) { 
            Console.WriteLine("Cost of meal: ");
                Console.WriteLine();
                costOfMeal = Convert.ToDouble(Console.ReadLine());

                GetTotalCost(.15, costOfMeal);
                GetTotalCost(.20, costOfMeal);
                GetTotalCost(.25, costOfMeal);

            Console.WriteLine("Continue? (y/n)");
            choice = Console.ReadLine();
            }
            Console.WriteLine("Later Nerd");

        }

        static void GetTotalCost(double tipPercent, double costOfMeal) {
            tipAmount = costOfMeal * tipPercent;
            totalCost = costOfMeal + tipAmount;
            Console.WriteLine(tipPercent.ToString("P"));
            Console.WriteLine("Tip Amount: " + tipAmount.ToString("C"));
            Console.WriteLine("Total Cost: " + totalCost.ToString("C"));
            Console.WriteLine();
        }

    }
}
