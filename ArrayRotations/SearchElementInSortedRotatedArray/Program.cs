using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchElementInSortedRotatedArray
{
    //
    //Search an element in a sorted and rotated array
    //An element in a sorted array can be found in O(log n) time via binary search.
    // But suppose we rotate an ascending order sorted array at some pivot unknown to you 
    // beforehand.So for instance, 1 2 3 4 5 might become 3 4 5 1 2. 
    //Devise a way to find an element in the rotated array in O(log n) time


    /*
     * Input  : arr[] = {5, 6, 7, 8, 9, 10, 1, 2, 3};
         key = 3
        Output : Found at index 8

        Input  : arr[] = {5, 6, 7, 8, 9, 10, 1, 2, 3};
                 key = 30
        Output : Not found

        Input : arr[] = {30, 40, 50, 10, 20}
                key = 10   
        Output : Found at index 3
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 6, 7, 8, 9, 1, 2, 3 };
            int key = 3;

            int index=PivotedBinarySearch(arr, arr.Length,key);

            Console.WriteLine("Index is {0}", index);
            Console.Read();
        }

        static int PivotedBinarySearch(int[] arr,int n, int key)
        {
            //First step to find the pivot
            int pivotIndex= FindPivot(arr,0, n-1);

            //array is not rotated
            if (pivotIndex ==-1)
                return BinarySearch(arr, 0, n - 1,key);
            if (arr[pivotIndex] == key)
                return pivotIndex;

            if (arr[0] <= key)
                return BinarySearch(arr,0,pivotIndex-1,key);

            return BinarySearch(arr,pivotIndex + 1,n-1, key);
        }

        private static int BinarySearch(int[] arr, int low, int high,int key)
        {
            if (high < low)
                return -1;

            int mid = (low + high) / 2;

            if (arr[mid] == key)
                return mid;
            if (key > arr[mid])
               return BinarySearch(arr, mid + 1, high, key);
            
            return BinarySearch(arr, low, mid-1, key);
        }

        private static int FindPivot(int[] arr, int low, int high)
        {
            if (high < low)
                return -1;
            if (high == low)
                return low;

            int mid = (low + high) / 2;

            if (mid>low && arr[mid] < arr[mid -1])
                return mid-1;
            if (mid<high && arr[mid] > arr[mid + 1])
                return mid;

            if (arr[low] > arr[mid])
                return FindPivot(arr, low, mid - 1);

            return FindPivot(arr, mid + 1, high);
            
        }
    }
}
