using System;

namespace ch4_control_structure {
    class Program {
        

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            // Control Strucures 
            string command = "";
            Console.WriteLine("COMMAND MENU");
            Console.WriteLine("list - list all");
            Console.WriteLine("add  - add an item");
            Console.WriteLine("exit - exit loop");
            
            while (!command.Contains("exit")) {
                Console.WriteLine("Enter a command");
                command = Console.ReadLine();

            switch (command) {
                    case "list":
                    case "List":
                    case "LIST":
                        Console.WriteLine("list selected");
                        break;
                    case "add":
                        Console.WriteLine("add selected");
                        break;
                    default:
                        Console.WriteLine("exit selected");
                        break;
                }


            }

            string[] names = { "Sarah", "Sam", "Tyler", "Jacob" };
            // in java: for (Type t : collection)
            foreach (string name in names) {
                Console.WriteLine(name);
            }

            Console.WriteLine("for loop");
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine(names[i]);
            }
            // useless
            Console.WriteLine(names);



            Console.WriteLine("Bye");
        }
    }
}
