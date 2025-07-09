//public access modifier

using System;

public class Car
{
    public string brand = "Toyota";

    public void Drive()
    {
        Console.WriteLine($"Drive {brand} car on the road.");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        Console.WriteLine(car.brand);  // public field accessible
        car.Drive();                   // public method accessible
    }
}

