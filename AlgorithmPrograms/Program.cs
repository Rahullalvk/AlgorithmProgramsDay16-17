namespace AlgorithmPrograms
{
    class InsertionSort
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of words (separated by spaces):");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Sorter sorter = new Sorter();

            sorter.Sort(words);

            Console.WriteLine("Sorted List:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    } 
}

    