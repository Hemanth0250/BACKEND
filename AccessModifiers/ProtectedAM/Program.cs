//Protected Access Modifier - can be accessed in derived classes and within the same class, but not outside of it.
using System;
public class Vehicle
{
    protected string model = "SUV"; // Only for base and derived classes
}

public class Car : Vehicle
{
    public void ShowModel()
    {
        Console.WriteLine("Model: " + model); // accessible in derived class
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.ShowModel(); //accessiable in derived class
        // Console.WriteLine(car.model); //Error: not accessible outside
    }
}
