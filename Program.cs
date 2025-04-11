using System;

class Program
{
    static void Main(string[] args)
    {
        // Addition section
        Console.WriteLine("Addition");
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number m: ");
        int m = int.Parse(Console.ReadLine());

        int sum = RecursiveSum(n, m);
        Console.WriteLine(sum);

        // Division section
        Console.WriteLine("Division");
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        int divisions = CountDivisionsByTwo(number);
        Console.WriteLine("Total number of divisions: " + divisions);
    }

    // Recursively calculates the sum from n to m
    static int RecursiveSum(int n, int m)
    {
        if (n > m)
            return 0;
        return n + RecursiveSum(n + 1, m);
    }

    // Counts how many times a number can be evenly divided by 2
    static int CountDivisionsByTwo(int number)
    {
        int count = 0;
        while (number % 2 == 0)
        {
            number /= 2;
            count++;
        }
        return count;
    }
}
