


class Program
{
    static void Main()
    {
        string[] wordList = ReadWordList();

        Console.Write("Enter a word to search: ");
        string searchWord = Console.ReadLine();

        Array.Sort(wordList);

        if (BinarySearch(wordList, searchWord))
            Console.WriteLine("The word is found in the list.");
        else
            Console.WriteLine("The word is not found in the list.");

        Console.ReadLine();
    }

    static string[] ReadWordList()
    {
        Console.Write("Enter the list of words separated by commas: ");
        string wordListInput = Console.ReadLine();

        return wordListInput.Split(',');
    }

    static bool BinarySearch(string[] wordList, string searchWord)
    {
        int left = 0;
        int right = wordList.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;

            int comparisonResult = string.Compare(searchWord, wordList[middle]);

            if (comparisonResult == 0)
                return true;
            else if (comparisonResult < 0)
                right = middle - 1;
            else
                left = middle + 1;
        }

        return false;
    }
}

