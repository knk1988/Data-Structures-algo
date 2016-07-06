using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxElement
{
    class Program
    {
        public static int BinarySearch(int[] arr, int left, int right)
        {
            int mid;

            if (arr.Length == 0)
                return -1;

            if (left == right)
                return arr[left];

            /* If there are two elements and first is greater then
                the first element is maximum */
            if ((right == left + 1) && arr[left] >= arr[right])
                return arr[left];

            /* If there are two elements and second is greater then
               the second element is maximum */
            if ((right == left + 1) && arr[left] < arr[right])
                return arr[right];

            mid = (left + right) / 2;

            /* If we reach a point where arr[mid] is greater than both of
                    its adjacent elements arr[mid-1] and arr[mid+1], then arr[mid]
                    is the maximum element*/
            if (arr[mid] > arr[mid + 1] && arr[mid] > arr[mid - 1])
                return arr[mid];

            /* If arr[mid] is greater than the next element and smaller than the previous 
                element then maximum lies on left side of mid */
            if (arr[mid] > arr[mid + 1] && arr[mid] < arr[mid - 1])
                return BinarySearch(arr, left, mid - 1);
            else // when arr[mid] is greater than arr[mid-1] and smaller than arr[mid+1]
                return BinarySearch(arr, mid + 1, right);

        }

        static void Main(string[] args)
        {
            //input
            int[] arr = { 8, 10, 20, 80, 100, 200, 400, 500, 3, 2, 1 };
            int left = 0;
            int right = arr.Length - 1;
            int max = BinarySearch(arr, left, right);
            Console.WriteLine("Maximum element is :" + max);
            Console.ReadLine();
        }
    }
}
