using System;
using System.Collections.Generic;

namespace list_demo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("C# List Demo");


            List<String> names = new List<string>();
            names.Add("Trevor");
            names.Add("Dennis");
            names.Add("Eric");
            names.Add("Jeff");

            names.Remove("Dennis");


            foreach (string s in names) {
                Console.WriteLine(s);
            }


        }
    }
}
