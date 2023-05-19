using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 9, 1, 3 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        Console.WriteLine("\nSorted array:");
        BubbleSort(numbers);
        PrintArray(numbers);

        int searchValue = 3;
        int linearSearchIndex = LinearSearch(numbers, searchValue);
        Console.WriteLine($"\nLinear search: {searchValue} found at index {linearSearchIndex}");

        int binarySearchIndex = BinarySearch(numbers, searchValue);
        Console.WriteLine($"Binary search: {searchValue} found at index {binarySearchIndex}");
    }

    static void BubbleSort<T>(T[] array) where T : IComparable<T>
    {
        int length = array.Length;
        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static int LinearSearch<T>(T[] array, T value) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(value))
            {
                return i;
            }
        }
        return -1;
    }

    static int BinarySearch<T>(T[] array, T value) where T : IComparable<T>
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int comparison = array[mid].CompareTo(value);

            if (comparison == 0)
            {
                return mid;
            }
            else if (comparison < 0)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }

    static void PrintArray<T>(T[] array)
    {
        foreach (T item in array)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
