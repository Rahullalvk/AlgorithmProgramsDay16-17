namespace AlgorithmPrograms 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> arr = new List<string> { "zebra", "apple", "banana", "orange", "grape" };

            Console.WriteLine("Before sorting:");
            PrintList(arr);

            MergeSort.Sort(arr);

            Console.WriteLine("\nAfter sorting:");
            PrintList(arr);
        }

        private static void PrintList(List<string> arr)
        {
            foreach (string item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}