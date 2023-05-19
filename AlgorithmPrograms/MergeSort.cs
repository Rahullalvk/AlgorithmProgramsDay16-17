using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class MergeSort
    {
        public static void Sort(List<string> arr)
        {
            if (arr == null || arr.Count <= 1)
                return;

            MergeSortHelper(arr, 0, arr.Count - 1);
        }

        private static void MergeSortHelper(List<string> arr, int lo, int hi)
        {
            if (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;

                MergeSortHelper(arr, lo, mid);
                MergeSortHelper(arr, mid + 1, hi);

                Merge(arr, lo, mid, hi);
            }
        }

        private static void Merge(List<string> arr, int lo, int mid, int hi)
        {
            int leftSize = mid - lo + 1;
            int rightSize = hi - mid;

            List<string> leftArr = new List<string>(leftSize);
            List<string> rightArr = new List<string>(rightSize);

            for (int i = 0; i < leftSize; i++)
                leftArr.Add(arr[lo + i]);

            for (int j = 0; j < rightSize; j++)
                rightArr.Add(arr[mid + 1 + j]);

            int leftIndex = 0, rightIndex = 0;
            int mergeIndex = lo;

            while (leftIndex < leftSize && rightIndex < rightSize)
            {
                if (String.Compare(leftArr[leftIndex], rightArr[rightIndex]) <= 0)
                {
                    arr[mergeIndex] = leftArr[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[mergeIndex] = rightArr[rightIndex];
                    rightIndex++;
                }
                mergeIndex++;
            }

            while (leftIndex < leftSize)
            {
                arr[mergeIndex] = leftArr[leftIndex];
                leftIndex++;
                mergeIndex++;
            }

            while (rightIndex < rightSize)
            {
                arr[mergeIndex] = rightArr[rightIndex];
                rightIndex++;
                mergeIndex++;
            }
        }
    }

}

