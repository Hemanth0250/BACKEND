//Private Access Modifier 
using System;

public class Car
{
    private string engineNumber = "ENG123";

    public void ShowEngine()
    {
        Console.WriteLine($"Engine Number: {engineNumber}");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        //Console.WriteLine(car.engineNumber); //not accessible, compiler error
        car.ShowEngine();                    //  Allowed
    }
}