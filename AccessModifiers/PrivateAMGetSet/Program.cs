// Private Access Modifier with Get and Set Methods
using System;
namespace AccessModifiers.PrivateAMGetSet
{
    public class Student
    {
        //Public Get and Set
        public string Name { get; set; }

        // Private Set – can read outside, set only inside
        public int Age { get; private set; }

        // Private Get – can set outside, read only inside
        public string SecretCode { private get; set; }

        public Student(string name, int age, string code)
        {
            Name = name;
            Age = age;
            SecretCode = code;
        }

        // Method to read private-get property inside class
        public void ShowSecret()
        {
            Console.WriteLine($"Secret Code: {SecretCode}");
        }

        // Method to modify private-set property
        public void SetAge(int newAge)
        {
            Age = newAge;
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student("Hemanth", 22, "XZ123");

            // Public get/set
            //get
            Console.WriteLine($"Name: {student.Name}");
            student.Name = "Gowda";
            //set                 
            Console.WriteLine($"Updated Name: {student.Name}");

            // Private set
            Console.WriteLine($"Age: {student.Age}");   //  get
                                                        
            student.SetAge(23);                         // change using method
            Console.WriteLine($"Updated Age: {student.Age}");

            //  Private get
            // Console.WriteLine(student.SecretCode); //Error,private get
            student.SecretCode = "NEW456";              
            student.ShowSecret();

        }
    }
}