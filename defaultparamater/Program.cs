// See https://aka.ms/new-console-template for more information
using System;

namespace DefaultParameter
{
    class Program
    {
        // Method with default parameters
        public void Greet(string name = "Criver", int age = 20)
        {
            Console.WriteLine($"Hello {name} !");
        }
        // Method with default parameters
        public void defpar(int a = 10, int b = 20, int c = 30)
        {
            Console.WriteLine($"a+b+c: {a + b + c}");
        }
        // Method with return type
        // This method returns an integer value
        public int returnmeth(int a, int b)
        {
            return a + b;
        }
        // Method with named arguments
        // This method displays a name and age
        public void Display(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Greet(); // Uses default parameters
            program.Greet("Alice", 25); // Uses provided parameters
            program.Greet("Bob"); // Uses default age
            program.Greet(age: 30); // Uses default name
            //defpar method calls
            program.defpar(); // Uses default parameters
            program.defpar(5, 15); // Uses provided parameters
            program.defpar(1, 2, 3); // Uses provided parameters
            program.defpar(b: 25); // Uses default a,b
            // Return method call
            int result = program.returnmeth(5, 10);
            Console.WriteLine($"Result of return method: {result}");
            int result2 = program.returnmeth(20, 30);
            Console.WriteLine($"Result of return method: {result2}");
            //named argument - display method call
            program.Display(name: "John", age: 30); // Named arguments
        }
    }
}
