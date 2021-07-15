using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotationProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            LeftRotateOneByOne.LeftRotate(arr, 2, 7);
            
            PrintArray(arr, 7);

            Console.WriteLine("\nArray Rotated using juggling Algorithm");
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };
            LeftRotateJugglingAlgorithm.LeftRotate(arr1, 2, 7);

            PrintArray(arr1, 7);
            Console.Read();
        }

        

        /* utility function to print an array */
        static void PrintArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

            
        }
    }
}
