using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string name;

        while (true)
        {
            Console.Write("What is your name? ");
            name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name) && !name.Any(char.IsDigit))
            {
                break;
            }

            Console.WriteLine("The name entered is invalid. Please enter a valid name using letters only.");
            Console.WriteLine();
        }

        int age;

        while (true)
        {
            Console.Write("How old are you? ");

            if (int.TryParse(Console.ReadLine(), out age))
            {
                break;
            }

            Console.WriteLine("The age entered is invalid. Please enter a valid whole number.");
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Hello, " + name + "!");

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are not an adult yet.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}