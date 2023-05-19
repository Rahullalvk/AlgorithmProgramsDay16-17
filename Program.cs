

class PrimeNumberFinder
{
    static void Main()
    {
        Console.WriteLine("Prime numbers between 0 and 1000:");
        FindPrimeNumbers(0, 1000);
    }

    static void FindPrimeNumbers(int start, int end)
    {
        for (int number = start; number <= end; number++)
        {
            if (IsPrime(number))
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
}

