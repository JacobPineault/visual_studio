using System;

namespace ch3_data_types {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Playing around with data types and math");

            double d1 = 55.77;
            double d2 = 11.34;

            double diff = d1 - d2;
            Console.WriteLine(diff);

            // compound assignment operators
            int n1 = 5;
            n1 += 7;
            n1 -= 2;
            n1 *= 3;
            Console.WriteLine(n1);

            // unary operators
            n1++;
            Console.WriteLine(n1);

            // random numbers
            Random random = new Random();

            int rand1 = random.Next();
            Console.WriteLine("Rand1 = " + rand1);

            int rand10 = random.Next(10);
            Console.WriteLine("Rand10 = " + rand10);

            for (int i = 0; i < 10; i++) {
                rand10 = random.Next(10);
                Console.WriteLine("Rand10 = " + rand10);
            }
            // random dice roll
            int rand6 = random.Next(6) + 1;

            // format a double as a currency
            double price1 = 199.399;
            Console.WriteLine("Price1 = " + price1.ToString("C2"));

            // format double as a percent
            double rate1 = 0.03577777777777;
            Console.WriteLine(rate1.ToString("P3"));




        }
    }
}
