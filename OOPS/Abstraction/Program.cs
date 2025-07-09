//Abstraction
using System;

namespace AbstractionExample
{
    // Abstract class
    public abstract class Animal
    {
        // Abstract method has no body
        // It must be implemented in derived classes
        public abstract void MakeSound();

        // Regular method 
        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }

    // Derived class
    public class Dog : Animal
    {
        // Providing body to abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    class Program
    {
        static void Main()
        {
            // Animal animal = new Animal(); // error, cannot create instance of abstract class
            Dog dog = new Dog();
            dog.MakeSound(); 
            dog.Eat();      
        }
    }
}

