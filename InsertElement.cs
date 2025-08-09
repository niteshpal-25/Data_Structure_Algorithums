using System;
using System.Text;

class Program
{
    static void Main()
    {
        int[] arr=new int[10]{1, 2, 4, 5, 6,0,0,0,0,0}
        int size=5;
        int index=2;
        int element=3;

        for(int i=size;i>index;i--){
            arr[i]=arr[i-1]
        }

        arr[index]=element;
        size++;

        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}