using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        do
        {
            Console.Write("Enter a number:");
            number = int.Parse(Console.ReadLine());

            if (number != 0)

            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = 0;
        foreach (int num in numbers)

        {
            sum += num;
        }

        //Average

        double average = (double)sum / numbers.Count;

        //the largest number

        int largestNumber = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > largestNumber)
            {
                largestNumber = num;
            }

        }

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largestNumber}");

    }
}