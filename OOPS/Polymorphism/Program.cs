//polymorphism example
using System;
namespace PolymorphismExample
{
    // Base class
    public class Vehicle
    {
        //using virtual method to allow overriding
        public virtual void Model()
        {
            Console.WriteLine("Cars are cars,thats it!");
        }
    }

    // Derived class
    public class BMW : Vehicle
    {
        public override void Model()
        {
            Console.WriteLine("BMW is a sport car");
        }
    }

    // Another derived class
    public class Mclearn : Vehicle
    {
        public override void Model()
        {
            Console.WriteLine("Mclearn is a super car");
        }
    }


    class Program
    {
        static void Main()
        {
            Vehicle myBMW = new BMW();
            Vehicle myMc = new Mclearn();

            myBMW.Model();  // Output: BMW is a sport car
            myMc.Model();   // Output: Mclearm is a super car
        }
    }
}