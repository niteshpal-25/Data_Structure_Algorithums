using System;

class Program
{
    static int? FindSecondLargest(int[] numbers)
    {
        if (numbers.Length < 2)
            return null; // Not enough numbers to find second largest

        int largest = numbers[0];
        int secondLargest = int.MinValue;

        for (int i = 1; i < numbers.Length; i++)
        {
            int current = numbers[i];

            if (current > largest)
            {
                secondLargest = largest;
                largest = current;
            }
            else if (current > secondLargest && current != largest)
            {
                secondLargest = current;
            }
        }

        if (secondLargest == int.MinValue)
            return null; // All numbers were same

        return secondLargest;
    }

    static void Main()
    {
        int[] data = { 12, 35, 1, 10, 34, 1 };
        int? result = FindSecondLargest(data);

        if (result.HasValue)
            Console.WriteLine("Second largest number is: " + result);
        else
            Console.WriteLine("No second largest number found");
    }
}
