using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();


        int user = -1;

        while (user != 0)

        {
            Console.Write("Enter a number (0 to quit): ");

            string answer = Console.ReadLine();
            user = int.Parse(answer);

            if (user != 0)

            {
                numbers.Add(user);
            }

        }

        int sum = 0;

        foreach (int number in numbers)

        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}");

        int max = numbers[0];

        foreach (int number in numbers)

        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}