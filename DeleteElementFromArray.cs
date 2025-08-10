using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int size = arr.Length;
        int indexToDelete = 2;        
        
        for (int i = indexToDelete; i < size - 1; i++)
        {
            arr[i] = arr[i + 1];
        }

        size--;

        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
