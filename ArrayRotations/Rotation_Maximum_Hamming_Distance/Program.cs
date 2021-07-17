using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotation_Maximum_Hamming_Distance
{
    /*
     * Given an array of n elements, create a new array which is a rotation of given array and hamming distance between both the arrays is maximum. 
    Hamming distance between two arrays or strings of equal length is the number of positions at which the corresponding character(elements) are different.
    Note: There can be more than one output for the given input. 
    Examples: 

    Input :  1 4 1
    Output :  2
    Explanation:  
    Maximum hamming distance = 2.
    We get this hamming distance with 4 1 1 
    or 1 1 4 

    Input :  N = 4
             2 4 8 0
    Output :  4
    Explanation: 
    Maximum hamming distance = 4
    We get this hamming distance with 4 8 0 2.
    All the places can be occupied by another digit.
    Other possible solutions are 8 0 2 4 and 0 2 4 8.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1,4,1 };
            int maxHammingDistance = GetMaxHammingDistance(arr,arr.Length);

            Console.WriteLine("Max Hamming Distance {0}", maxHammingDistance);

            Console.Read();
        }

        //This has time Complexity of O(n*n)
        //Without using any extra space
        private static int GetMaxHammingDistance(int[] arr, int size)
        {
            int maxHamDist = 0;
            for (int i = 0; i < size; i++)
            {
                int currHammingDist = 0;
                //In each rotation we need to check if place value digits are different than the rotated value
                for (int j = i+1,k=0; k < size; j++,k++)
                {
                    if (arr[k]!=arr[j%size])
                    {
                        currHammingDist++;
                    }
                }
                maxHamDist = Math.Max(currHammingDist, maxHamDist);
            }
            return maxHamDist;
        }
    }
}
