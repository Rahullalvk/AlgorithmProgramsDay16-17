using System;
using System.Collections.Generic;

class PrimeNumberFinder
{
    static void Main()
    {
        Console.WriteLine("Prime numbers between 0 and 1000 that are anagrams and palindromes:");
        FindAnagramPalindromePrimes(0, 1000);
    }

    static void FindAnagramPalindromePrimes(int start, int end)
    {
        for (int number = start; number <= end; number++)
        {
            if (IsPrime(number) && IsAnagram(number) && IsPalindrome(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static bool IsAnagram(int number)
    {
        string originalNumber = number.ToString();
        char[] charArray = originalNumber.ToCharArray();
        Array.Sort(charArray);
        string sortedNumber = new string(charArray);

        for (int i = number + 1; i <= 1000; i++)
        {
            string currentNumber = i.ToString();
            charArray = currentNumber.ToCharArray();
            Array.Sort(charArray);
            string sortedCurrentNumber = new string(charArray);

            if (sortedNumber.Equals(sortedCurrentNumber))
            {
                return true;
            }
        }

        return false;
    }

    static bool IsPalindrome(int number)
    {
        string originalNumber = number.ToString();
        char[] charArray = originalNumber.ToCharArray();
        Array.Reverse(charArray);
        string reversedNumber = new string(charArray);

        return originalNumber.Equals(reversedNumber);
    }
}


