using System;

namespace prj2_2_GradeConverter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to the Letter Grade Converter");
            String letterGrade;
            int grade = 0;
            String choice = "y";

            while (choice.Contains("y") || choice.Contains("Y")) 
            {
                Console.WriteLine("Enter a numerical grade: ");
                grade = Convert.ToInt32(Console.ReadLine());

                if (grade >= 88) {
                    letterGrade = "A";
                } else if (grade >= 80) {
                    letterGrade = "B";
                } else if (grade >= 67) {
                    letterGrade = "C";
                } else if (grade >= 60) {
                    letterGrade = "D";
                } else {
                    letterGrade = "F";
                }

                Console.WriteLine("Letter grade: " + letterGrade);
                Console.WriteLine();
                Console.WriteLine("Would you like to continue? (y/n)");
                choice = Console.ReadLine();

            }
            Console.WriteLine("Bye");
        }
        
    }

}