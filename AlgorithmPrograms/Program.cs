namespace AlgorithmPrograms 
{  

class BubbleSort
{
    static void Main()
    {
        Console.WriteLine("Enter the integers :");

        var numbers = new List<int>();
        string input;
        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        BubbleSortAscending(numbers);

        Console.WriteLine("Sorted List:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    static void BubbleSortAscending(List<int> numbers)
    {
        int n = numbers.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
    }
}
}
