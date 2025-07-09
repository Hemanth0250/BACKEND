//Encapsulation
using System;
public class Person
{
    // Step 1: Private field
    private string name;

    // Step 2: Public property to access private field
    public string Name
    {
        get { return name; }              // getter returns value
        set { name = value; }             // setter assigns value
    }
}
class Program
{
    static void Main()
    {
        Person p = new Person();

        // Set value using property
        p.Name = "Hemanth";

        // Get value using property
        Console.WriteLine("Name: " + p.Name);
        Console.WriteLine(p.name); // Error: 'Person.name' is inaccessible due to its protection level
    }
}