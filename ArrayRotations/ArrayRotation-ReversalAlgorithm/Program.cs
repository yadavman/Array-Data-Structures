using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation_ReversalAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            int d = 8;

            ReversalArrayRotation(arr,d,arr.Length);
            PrintArray(arr, arr.Length);

            Console.Read();

        }

        private static void ReversalArrayRotation(int[] arr, int d, int n)
        {
            //Reverse SubArray 0--d-1

            ReverseArray(arr, 0,d-1);
            ReverseArray(arr, d, n-1);
            ReverseArray(arr, 0, n - 1);
        }

        private static void ReverseArray(int[] arr, int start, int end)
        {
            //Check basic errors youself
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        /* utility function to print an array */
        static void PrintArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");


        }
    }
}
