//interface
using System;

namespace InterfaceExample
{
    // Interface definition
    public interface IAnimal
    {
        void MakeSound();          // Method (no body)
        string Name { get; set; }  // Property
    }

    // Class implementing the interface
    public class Dog : IAnimal
    {
        public string Name { get; set; }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }

    public class Cat : IAnimal
    {
        public string Name { get; set; }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog { Name = "Buddy" };
            dog.MakeSound();

            IAnimal cat = new Cat { Name = "Whiskers" };
            cat.MakeSound();
        }
    }
}
