using System;

class Program
{
    static void ReverseArray(int[] arr)
    {
        for (int left = 0, right = arr.Length - 1; left < right; left++, right--)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        ReverseArray(arr);
        Console.WriteLine(string.Join(", ", arr)); // Output: 5, 4, 3, 2, 1
    }
}
