using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

             List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers. Enter 0 to stop.");

        while (true)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        List<int> positiveNumbers = numbers.Where(n => n > 0).ToList();
        int smallestPositive = positiveNumbers.Any() ? positiveNumbers.Min() : 0;

        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"The sort list is: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
    
