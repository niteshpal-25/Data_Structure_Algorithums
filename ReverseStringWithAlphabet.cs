using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input1 = "a-bcd";
        string input2 = "ab-c/de!";

        Console.WriteLine(ReverseOnlyAlphabets(input1)); // Output: d-cba
        Console.WriteLine(ReverseOnlyAlphabets(input2)); // Output: ed-c/ba!
    }

    static string ReverseOnlyAlphabets(string s)
    {
        char[] chars = s.ToCharArray();
        int left = 0;
        int right = chars.Length - 1;

        while (left < right)
        {
            if (!char.IsLetter(chars[left]))
            {
                left++;
            }
            else if (!char.IsLetter(chars[right]))
            {
                right--;
            }
            else
            {
                // Swap letters
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }
        }

        return new string(chars);
    }
}
