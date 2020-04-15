using System;

namespace ch7_classes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Create some Products!");

            Product p1 = new Product("Java", "Murach's Java", 57.50);
            Product p2 = new Product(".NET", "Murach's .NET", 58.50);

            Console.WriteLine(p1);
            Console.WriteLine(p2);



        }
    }

    class Product {
        string Code;
        string Description;
        double Price;

        public Product() {
            Code = "";
            Description = "";
            Price = 0.0;

        }

        public Product(string code, string description, double price) {
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        public override string ToString() {
            // interpollation example - use back-tick `. left of the #1 key
            return $"Product: Code={Code}, Description={Description}, Price={Price.ToString("C")}";
        }
    }
}
