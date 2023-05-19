public class Permutation
{
    public static string[] GetPermutationsIterative(string str)
    {
        List<string> permutations = new List<string>();
        permutations.Add(str);

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j < str.Length; j++)
            {
                permutations.AddRange(SwapChars(str, i, j));
            }
        }

        return permutations.ToArray();
    }

    private static List<string> SwapChars(string str, int i, int j)
    {
        char[] charArray = str.ToCharArray();
        char temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;

        return new List<string> { new string(charArray) };
    }

    public static string[] GetPermutationsRecursive(string str)
    {
        List<string> permutations = new List<string>();
        GetPermutationsRecursiveHelper(str.ToCharArray(), 0, permutations);
        return permutations.ToArray();
    }

    private static void GetPermutationsRecursiveHelper(char[] charArray, int index, List<string> permutations)
    {
        if (index == charArray.Length - 1)
        {
            permutations.Add(new string(charArray));
        }
        else
        {
            for (int i = index; i < charArray.Length; i++)
            {
                Swap(ref charArray[index], ref charArray[i]);
                GetPermutationsRecursiveHelper(charArray, index + 1, permutations);
                Swap(ref charArray[index], ref charArray[i]);
            }
        }
    }

    private static void Swap(ref char a, ref char b)
    {
        char temp = a;
        a = b;
        b = temp;
    }
}

public class Program
{
    public static void Main()
    {
        string str = "abc";

        string[] iterativePermutations = Permutation.GetPermutationsIterative(str);
        string[] recursivePermutations = Permutation.GetPermutationsRecursive(str);

        Console.WriteLine("Iterative Permutations:");
        foreach (string permutation in iterativePermutations)
        {
            Console.WriteLine(permutation);
        }

        Console.WriteLine("Recursive Permutations:");
        foreach (string permutation in recursivePermutations)
        {
            Console.WriteLine(permutation);
        }

        bool areEqual = ArraysEqual(iterativePermutations, recursivePermutations);
        Console.WriteLine("Are the arrays equal? " + areEqual);
    }

    private static bool ArraysEqual(string[] array1, string[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }

        return true;
    }
}
