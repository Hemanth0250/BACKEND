//inhertiance and sealed classes
using System;

namespace InheritanceExample
{
    // class vehicle inherited by car class
    public class Vehicle
    {
        public string brand = "BMW";
        public void Mode()
        {
            Console.WriteLine("RACING...");
        }
    }

    // Derived class
    public class Car : Vehicle
    {
        public string model = "M4";
    }

    // Sealed class 
    public sealed class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    
    //public class Dog : Animal { } // Error,Animal is sealed and cannot be inherited
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.Mode();  //inherited method from Vehicle
            //inherited field from Vehicle
            Console.WriteLine($"Brand: {car.brand}, Model: {car.model}");
            //sealed class
            Animal animal = new Animal();
            animal.Eat();  
        }
    }
}
