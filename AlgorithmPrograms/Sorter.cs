using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{

        class Sorter
        {
            public void Sort(string[] arr)
            {
                int n = arr.Length;
                for (int i = 1; i < n; i++)
                {
                    string key = arr[i];
                    int j = i - 1;

                    while (j >= 0 && string.Compare(arr[j], key) > 0)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }

                    arr[j + 1] = key;
                }
            }
        }
}
