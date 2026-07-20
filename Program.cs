using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string name = GetValidName();
        int age = GetValidAge();

        Console.WriteLine();
        Console.WriteLine("Hello, " + name + "!");

        if (IsAdult(age))
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

    static string GetValidName()
    {
        while (true)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            if (IsValidName(name))
            {
                return name;
            }

            Console.WriteLine("The name entered is invalid. Please enter a valid name using letters only.");
            Console.WriteLine();
        }
    }

    static int GetValidAge()
    {
        while (true)
        {
            Console.Write("How old are you? ");

            if (int.TryParse(Console.ReadLine(), out int age) && IsValidAge(age))
            {
                return age;
            }

            Console.WriteLine("The age entered is invalid. Please enter a whole number between 0 and 120.");
            Console.WriteLine();
        }
    }

    public static bool IsValidName(string name)
    {
        return !string.IsNullOrWhiteSpace(name) && !name.Any(char.IsDigit);
    }

    public static bool IsValidAge(int age)
    {
        return age >= 0 && age <= 120;
    }

    public static bool IsAdult(int age)
    {
        return age >= 18;
    }
}