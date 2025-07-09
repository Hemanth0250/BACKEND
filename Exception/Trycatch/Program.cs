//Exception handling
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = 100 / number;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You can't divide by zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("This is the finally block. It always runs.");
        }

        Console.WriteLine("Program reached the end.");
    }
}
