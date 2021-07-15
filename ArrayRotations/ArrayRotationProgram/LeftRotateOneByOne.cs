using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotationProgram
{
    public static class LeftRotateOneByOne
    {
        public static void LeftRotate(int[] arr, int d,
                           int n)
        {
            for (int i = 0; i < d; i++)
                LeftRotatebyOne(arr, n);
        }

        static void LeftRotatebyOne(int[] arr, int n)
        {
            int i, temp = arr[0];
            for (i = 0; i < n - 1; i++)
                arr[i] = arr[i + 1];

            arr[n - 1] = temp;
        }
    }
}
