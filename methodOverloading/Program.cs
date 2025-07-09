//method overloading example
using System;
namespace MethodOverloading
{
    class Calculator
    {
        // Method 1: Add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method 2: Add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method 3: Add two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method 4: Add one int and one double
        public double Add(int a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Add(int, int): " + calc.Add(10.2, 20.3));
            Console.WriteLine("Add(int, int, int): " + calc.Add(1, 2, 3));
            Console.WriteLine("Add(double, double): " + calc.Add(2.5, 3.7));
            Console.WriteLine("Add(int, double): " + calc.Add(5, 4));
        }
    }
}
    