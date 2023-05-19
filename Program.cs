
class NumberGuesser
{
    static int GuessNumber(int low, int high)
    {
        if (low == high)
            return low;

        int mid = (low + high) / 2;

        Console.WriteLine("Is your number between {0} and {1}? (y/n)", low, mid);
        string response = Console.ReadLine().ToLower();

        if (response == "y")
            return GuessNumber(low, mid);
        else if (response == "n")
            return GuessNumber(mid + 1, high);
        else
        {
            Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            return GuessNumber(low, high);
        }
    }

    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide the value of N as a command-line argument.");
            return;
        }

        int n;
        if (!int.TryParse(args[0], out n) || n <= 0 || (n & (n - 1)) != 0)
        {
            Console.WriteLine("Invalid value of N. N should be a power of 2.");
            return;
        }

        int number = GuessNumber(0, n - 1);
        Console.WriteLine("The number you were thinking of is: " + number);
    }
}
