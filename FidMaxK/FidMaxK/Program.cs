using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FidMaxK
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] input = new int[] { 4,5,6,7,8 };
            int val = FindMaxValueK(input);
            Console.Write(val);
            Console.Read();
        }

        public static int FindMaxValueK(int[] arr)
        {
            int n = arr.Length;
            int[] freq = Enumerable.Repeat(0, n + 1).ToArray();

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < n)
                    freq[arr[i]]++;
                else
                    freq[n]++;
            }

            int sum = 0;

            for (int ans = n; ans > 0; ans--)
            {
                sum += freq[ans];

                if (sum >= ans)
                    return ans;

            }
            return -1;

        }
    }
}
