using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumOfArrayWithRotation
{
    public class Program
    {
        /*
         * Given an array, only rotation operation is allowed on array.
         * We can rotate the array as many times as we want. 
         * Return the maximum possible summation of i*arr[i].
         * Input: arr[] = {1, 20, 2, 10}
            Output: 72
            We can get 72 by rotating array twice.
            {2, 10, 1, 20}
            20*3 + 1*2 + 10*1 + 2*0 = 72

            Input: arr[] = {10, 1, 2, 3, 4, 5, 6, 7, 8, 9}
            Output: 330
            We can get 330 by rotating array 9 times.
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            0*1 + 1*2 + 2*3 ... 9*10 = 330
         */
        public static void Main(string[] args)
        {
            int[] arr= { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int size = arr.Length;

            //Formula Based on Derivation Of LEft Rotation
            //Rj- Rj+1= Rj + narr[j-1]- arrSum

            int arrSum = arr.Sum();
            
            int prevValue = 0;

            for (int i = 0; i < size; i++)
            {
                prevValue += i * arr[i];
            }
            int maxValue = prevValue;
            int currentValue = 0;
            for (int i = 1; i < size; i++)
            {
                currentValue = prevValue + size * arr[i - 1] - arrSum;
                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                }
                prevValue = currentValue;
            }

            Console.Write(maxValue);
            Console.Read();
        }
    }
}
