using System;

namespace ch5_dice_roller {
    class Program {



        static void Main(string[] args) {
            Console.WriteLine("Dice Roller");
            string choice = "y";
            int die1;
            int die2;
            
            
            Console.WriteLine("Would you like to roll some dice? (y/n)");
            choice = Console.ReadLine();

            while (!choice.Contains("n")) {
            
             die1 = RollThemDice();
             die2 = RollThemDice();
                string specialMessage = Condition(die1, die2);

                Console.WriteLine("Die 1: " + die1);
                Console.WriteLine("Die 2: " + die2);               
                Console.WriteLine(specialMessage);
                Console.WriteLine();
                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Cya");
        }

        private static int RollThemDice() {
            Random rnd = new Random();
            int dieValue = rnd.Next(1, 7);
            return dieValue;
        }

        private static string Condition(int die1, int die2) {
            string flavorText = "";
            
            if (die1==1 && die2==1) {
                flavorText = "Snake eyes!";
            }
            else if (die1==2 && die2==2) {
                flavorText = "Ballerina!";
            }
            else if ((die1+die2)==8) {
                flavorText = "Octopus!";
            }
            else if (die1==5 && die2==5) {
                flavorText = "Puppy Paws";
            }
            else if (die1==6 && die2==6) {
                flavorText = "Stacked, Bro";
            }
            else if ((die1==5 && die2==6) || (die1 == 6 && die2 == 5)) {
                flavorText = "Yo eleven! Six five, no jive!";
            }
            return flavorText;
        }


    }
}
