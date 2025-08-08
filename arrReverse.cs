using System;

class Program
{
    static void ReverseArray(int[] arr, int left, int right)
    {
        if (left >= right)
            return;

        // Swap elements
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;

        ReverseArray(arr, left + 1, right - 1);
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        ReverseArray(arr, 0, arr.Length - 1); // Passing left & right explicitly
        Console.WriteLine(string.Join(", ", arr)); // Output: 5, 4, 3, 2, 1
    }
}