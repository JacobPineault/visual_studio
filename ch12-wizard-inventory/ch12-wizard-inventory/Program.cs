using System;
using System.Collections.Generic;

namespace ch12_wizard_inventory {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("The Wizard Inventory Game");
            String command = "";

            CommandMenu();

            Dictionary<int, string> wizardBag = new Dictionary<int, string>();
            wizardBag.Add(1, "Floppy Staff of the Rubber Tree");
            wizardBag.Add(2, "Wizard Hat of Arcane Brilliance");
            wizardBag.Add(3, "Cloth Shoes of Numb Toes");


            Console.WriteLine("Command: ");
            command = Console.ReadLine();

            while (!command.Contains("exit")) { 
            switch (command) {
                case "show": //display items
                    for (int i = 1; i <= wizardBag.Count; i++) {
                        Console.WriteLine(i + "- " + wizardBag[i]);
                    }
                    break;
                case "grab":
                    if (wizardBag.Count < 5) {
                            Console.WriteLine("What is the name of the item? ");
                            string newItem = Console.ReadLine();
                            wizardBag.Add((wizardBag.Count + 1), newItem);
                            Console.WriteLine(newItem + " was added to inventory.");
                    }
                    else {
                        Console.WriteLine("Inventory at maximum capacity!");
                    }
                    break;
                case "exch":
                        Console.WriteLine("Which item slot should be exchanged? ");
                        int exchItem = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the name of the new item?");
                        string supItem = Console.ReadLine();
                        if (exchItem < 5 && exchItem >0) {
                            wizardBag[exchItem] = supItem;
                        }
                        else {
                            Console.WriteLine("Could not find specified item");
                        }

                    break;
                case "drop":
                        Console.WriteLine("Which number slot do you wish to drop? ");
                        int dropItem = Convert.ToInt32(Console.ReadLine());
                        if (dropItem > 0 && dropItem < 5) { 
                        wizardBag.Remove(dropItem);
                        Console.WriteLine(dropItem + " was disguarded.");
                        }
                        else {
                            Console.WriteLine("Could not drop item.");
                        }
                    break;
                case "help": 
                    CommandMenu();
                    break;
                case "exit": 
                    break;
                default:
                    Console.WriteLine("Invalid command. Please reenter");
                    break;
            }
                Console.WriteLine("Next command? ");
                command = Console.ReadLine();
            }

        }

        private static void CommandMenu() {
            Console.WriteLine("===== COMMAND MENU =====");
            Console.WriteLine("========================");
            Console.WriteLine("show - Show all items");
            Console.WriteLine("grab - Grab all item");
            Console.WriteLine("exch - Exchange an item");
            Console.WriteLine("drop - Drop an item");
            Console.WriteLine("help - Display Command Menu");
            Console.WriteLine("exit - Tran-Dimensional Teleport");
            Console.WriteLine("========================");

        }

    }
}
