using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReArrangeArray
{
    public class Program
    {
        /*
         * Given an array of elements of length N, ranging from 0 to N – 1.
         * All elements may not be present in the array. 
         * If the element is not present then there will be -1 present in the array. 
         * Rearrange the array such that arr[i] = i and if i is not present, display -1 at that place.

            Examples: 

            Input : arr = {-1, -1, 6, 1, 9, 3, 2, -1, 4, -1}
            Output : [-1, 1, 2, 3, 4, -1, 6, -1, -1, 9]

            Input : arr = {19, 7, 0, 3, 18, 15, 12, 6, 1, 8,
                          11, 10, 9, 5, 13, 16, 2, 14, 17, 4}
            Output : [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 
                     11, 12, 13, 14, 15, 16, 17, 18, 19]
         */
        public static void Main(string[] args)
        {
            int[] arr = { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1 && arr[i] != i)
                {
                    int x = arr[i];

                    // check if desired
                    // place is not vacate
                    while (arr[x] != -1 && arr[x] != x)
                    {
                        // store the value
                        // from desired place
                        int y = arr[x];

                        // place the x to its
                        // correct position
                        arr[x] = x;

                        // now y will become x,
                        // now search the place
                        // for x
                        x = y;
                    }

                    // place the x to its
                    // correct position
                    arr[x] = x;

                    // check if while loop
                    // hasn't set the correct
                    // value at arr[i]
                    if (arr[i] != i)
                    {
                        // if not then put -1
                        // at the vacated place
                        arr[i] = -1;
                    }
                }
            }

            Console.WriteLine(String.Join(",",arr));
            Console.Read();
        }
    }
}
