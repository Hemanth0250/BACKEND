using System;

namespace EnumExample
{
    // Define an enum for days of the week
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Assign enum values to variables
            // string dayy = Console.ReadLine("Enter a day of the week: ");
            DayOfWeek today = DayOfWeek.Monday; // Example assignment
            DayOfWeek anotherDay = DayOfWeek.Friday;

            // Use the enum value in a switch statement
            switch (today)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's Sunday!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("It's Monday!");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("It's Tuesday!");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("It's Wednesday!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("It's Thursday!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("It's Friday!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("It's Saturday!");
                    break;

            }
            Console.WriteLine("Another Day: " + anotherDay);

        }
    }
}
