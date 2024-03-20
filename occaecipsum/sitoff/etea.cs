// This is a code snippet that sorts a list of numbers in ascending order in C#
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of numbers
        List<int> numbers = new List<int>() { 5, 3, 8, 1, 4, 9, 2, 6, 7 };

        // Sort the list in ascending order using the Sort method
        numbers.Sort();

        // Print the sorted list
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
