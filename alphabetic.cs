using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the names (one name per line). Press Enter on an empty line to finish:");

        List<string> names = new List<string>();

        // Read names from the user
        string name;
        while (!string.IsNullOrWhiteSpace(name = Console.ReadLine()))
        {
            names.Add(name);
        }

        // Sort names alphabetically
        names.Sort();

        // Display the sorted names
        Console.WriteLine("Sorted names:");
        foreach (string sortedName in names)
        {
            Console.WriteLine(sortedName);
        }
    }
}
