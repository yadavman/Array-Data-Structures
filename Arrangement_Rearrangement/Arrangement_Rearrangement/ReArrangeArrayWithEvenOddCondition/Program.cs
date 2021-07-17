using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReArrangeArrayWithEvenOddCondition
{
    /*
     * Rearrange array such that arr[i] >= arr[j] if i is even and arr[i]<=arr[j] if i is odd and j < i

        Given an array of n elements. 
        Our task is to write a program to rearrange the array such that elements 
        at even positions are greater than all elements before it and elements 
        at odd positions are less than all elements before it.
        Examples: 
 

        Input : arr[] = {1, 2, 3, 4, 5, 6, 7}
        Output : 4 5 3 6 2 7 1

        Input : arr[] = {1, 2, 1, 4, 5, 6, 8, 8} 
        Output : 4 5 2 6 1 8 1 8
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, 4, 5, 6, 8, 8 };

            Array.Sort(arr);

            int[] newArr = new int[arr.Length];
            int n = arr.Length;
            for (int i = n-1, j=0,k=n-1; k>=0; i--,j++,k=k-2)
            {
                if (n%2==0)
                {
                    newArr[k] = arr[i];
                    newArr[k-1] = arr[j];
                }
                else
                {
                    newArr[k] = arr[j];
                    if (k-1>=0)
                    {
                        newArr[k - 1] = arr[i];
                    }
                    
                }
                
            }

            Console.WriteLine(String.Join(",", newArr));
            Console.Read();

        }
    }
}
