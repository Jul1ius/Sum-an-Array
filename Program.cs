using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        int[] numbers = new int[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (int.TryParse(inputArray[i], out int number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter integers separated by spaces.");
                return;
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine(sum);
    }
}

