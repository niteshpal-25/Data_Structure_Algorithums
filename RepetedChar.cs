using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(FirstUniqueChar("amazon")); // Output: 0
        Console.WriteLine(FirstUniqueChar("swiss"));  // Output: 1
    }

    static int FirstUniqueChar(string s)
    {
        int[] freq = new int[256]; // ASCII size        
        foreach (char c in s)
        {
            freq[c]++;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (freq[s[i]] == 1)
            {
                return i; 
            }
        }

        return -1; // No unique character found
    }
}
