using System;

namespace OopsClassObjects
{
    // Class
    public class Car
    {
        //class members
        // Fields
        public string brand;
        public string color;

        // Constructor
        public Car(string brand, string color)
        {
            this.brand = brand;
            this.color = color;
        }

        // Method
        public void Drive()
        {
            Console.WriteLine(brand + " is driving");
        }
    }

    // Main Program class
    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects using the constructor
            //object1
            Car car1 = new Car(color: "Black", brand: "BMW");
            Console.WriteLine("Car 1 brand: " + car1.brand + ", Color: " + car1.color);
            car1.Drive();
            //object2
            Car car2 = new Car("Audi", "Red");
            Console.WriteLine("Car 2 brand: " + car2.brand + ", Color: " + car2.color);
            car2.Drive();
            //object3
            Car car3 = new Car("Mercedes", "White");
            Console.WriteLine("Car 3 brand: " + car3.brand + ", Color: " + car3.color);
            car3.Drive();
        }
    }
}
