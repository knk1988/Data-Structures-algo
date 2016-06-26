using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregation
{
    public class Program
    {
        /// <summary>
        /// Two way Partition
        /// </summary>
        /// <param name="arr"></param>
        public static void Segregate0and1(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                while (arr[left] == 0 && left < right)
                    left++;

                while (arr[right] == 1 && left < right)
                    right--;

                if(left < right)
                {
                    arr[left] = 0;
                    arr[right] = 1;
                    left++;
                    right--;
                }
            }
        }

        /// <summary>
        /// Three way Partition
        /// </summary>
        /// <param name="arr"></param>
        public static void DutchNationalFlag(int[] arr)
        {
            int low = 0;
            int mid = 0;
            int high = arr.Length - 1;

            while (mid <= high)
            {
                switch (arr[mid])
                {
                    case 0:
                        {
                            Swap(arr, low, mid);
                            low++;
                            mid++;
                            break;
                        }
                    case 1:
                        {
                            mid++;
                            break;
                        }
                    case 2:
                        {
                            Swap(arr, mid, high);
                            high--;
                            break;
                        }
                }
            }           
        }

        /// <summary>
        /// Util function to swap 2 numbers in an int array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="indexLow"></param>
        /// <param name="indexHigh"></param>
        public static void Swap(int[] arr, int indexLow, int indexHigh)
        {
            int temp = arr[indexLow];
            arr[indexLow] = arr[indexHigh];
            arr[indexHigh] = temp;
        }

        /// <summary>
        /// Util function to print array
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Drive Program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int[] arr = new int[] {0, 0, 1, 1, 1, 1, 0};
            Console.WriteLine("Before Segregtion 0s & 1s:");
            PrintArray(arr);
            Segregate0and1(arr);
            Console.WriteLine("After Segregtion 0s & 1s:");
            PrintArray(arr);

            int[] arr1 = new int[] { 2, 0, 1, 2, 1, 0, 0, 1, 2 };
            Console.WriteLine("Before Segregtion 0s & 1s & 2s:");
            PrintArray(arr1);
            DutchNationalFlag(arr1);
            Console.WriteLine("After Segregtion 0s & 1s & 2s:");
            PrintArray(arr1);
            Console.Read();
        }

      
    }   
}
