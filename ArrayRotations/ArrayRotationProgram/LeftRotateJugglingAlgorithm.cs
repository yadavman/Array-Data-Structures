using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotationProgram
{
    public static class LeftRotateJugglingAlgorithm
    {
        public static void LeftRotate(int[] arr, int d,
                           int n)
        {
            int i, j, k, temp;
            d = d % n;
            int gcd = GCD(d, n);
            for (i = 0; i < gcd; i++)
            {
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }

                arr[j] = temp;
            }
        }

        

        static int GCD(int a , int b)
        {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }
    }
}
