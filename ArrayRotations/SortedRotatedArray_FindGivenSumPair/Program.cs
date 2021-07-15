using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedRotatedArray_FindGivenSumPair
{
    /*
     * Given a sorted and rotated array, find if there is a pair with a given sum
     * Input: arr[] = {11, 15, 6, 8, 9, 10}, x = 16
        Output: true
        There is a pair (6, 10) with sum 16

        Input: arr[] = {11, 15, 26, 38, 9, 10}, x = 35
        Output: true
        There is a pair (26, 9) with sum 35

        Input: arr[] = {11, 15, 26, 38, 9, 10}, x = 45
        Output: false
        There is no pair with sum 45.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            //int[] arr = { 11, 15, 6, 8, 9, 10 };

            int[] arr = { 6, 8, 9, 10 ,11,12};

            int sum = 19;
            int size = arr.Length;

            CheckPairSum(arr,sum,size);

            CheckPairSumUsingHashing(arr, sum, size);

            Console.Read();
        }
        private static void CheckPairSumUsingHashing(int[] arr, int sum, int size)
        {
            bool isSumPresent = false;

            HashSet<int> set = new HashSet<int>();

            set.Add(arr[0]);
            for (int i = 1; i < size; i++)
            {
                int temp = sum - arr[i];
                if (set.Contains(temp))
                {
                    isSumPresent = true;
                    break;
                }
                set.Add(arr[i]);
            }
            
            Console.WriteLine("Given Pair Sum is {0}", isSumPresent);
        }
        private static void CheckPairSum(int[] arr, int sum,int size)
        {
            bool isSumPresent = false;

            //Find The Pivoted Element and we can do exreme left and extreme right sum 

            int maxPivotIndex = FindPivot(arr, 0, arr.Length - 1);

            int minPivotIndex = maxPivotIndex + 1;

            int start = (maxPivotIndex == -1) ? 0 : minPivotIndex;
            int end = (maxPivotIndex == -1) ? size - 1 : maxPivotIndex;

            while (start != end)
            {
                int tot = arr[start] + arr[end];
                if (tot == sum)
                {
                    isSumPresent = true;
                    break;
                }
                if (sum < tot)
                    end = (end - 1) < 0 ? size - end - 1 : end - 1;
                else
                    start = (start + 1) % size;


            }
            Console.WriteLine("Given Pair Sum is {0}", isSumPresent);
        }

        private static int FindPivot(int[] arr, int low, int high)
        {
            if (high<=low)
                return -1;
            if (low == high)
                return low;

            int mid = (low + high) / 2;

            if (low < mid && arr[mid] < arr[mid - 1])
                return mid - 1;
            if (high > mid && arr[mid] > arr[mid + 1])
                return mid;

            if (arr[low] > arr[mid])
                return FindPivot(arr, low, mid - 1);

            return FindPivot(arr, mid, high-1);
        }
    }
}
