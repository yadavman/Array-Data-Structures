using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotations_BlockRotationAlgo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            LeftRotate(arr, 2, 7);
            PrintArray(arr, 7);

            Console.Read();
        }

        public static void LeftRotate(int[] arr,
                              int d, int n)
        {
            LeftRotateRecursive(arr, 0, d, n);
        }

        private static void LeftRotateRecursive(int[] arr, int i, int d, int n)
        {
            //Base Condition
            if (d == 0 || d == n)
                return;

            //if no of elemenst to be rotated is half we can just swap
            if (n-d==d)
            {
                Swap(arr, i, n - d, d);
                return;
            }

            if (d<n-d)
            {
                Swap(arr, i, n - d + i, d);
                LeftRotateRecursive(arr, i, d, n - d);
            }
            else
            {
                Swap(arr, i, d, n-d);
                LeftRotateRecursive(arr, n-d+i, 2*d-n, d);
            }
        }

        private static void Swap(int[] arr, int start, int end, int d)
        {
            int i, temp;
            for (i = 0; i < d; i++)
            {
                temp = arr[start + i];
                arr[start + i] = arr[end + i];
                arr[end + i] = temp;
            }
        }

        public static void PrintArray(int[] arr,
                              int size)
        {
            int i;
            for (i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
