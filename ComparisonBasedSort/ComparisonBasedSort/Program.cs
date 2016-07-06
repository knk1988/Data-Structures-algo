using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonBasedSort
{
    public class Program
    {        
        public static void Main(string[] args)
        {
            string[] arr = { "54", "546", "60", "15", "7", "6", "28" };
            Array.Sort(arr, delegate (string item1, string item2) {
                // first append item2 at the end of item1
                string XY = item1 += item2;

                // then append item1 at the end of item2
                string YX = item2 += item1;

                // Now see which of the two formed numbers is greater
                return XY.CompareTo(YX);
            });
            // reverse the array
            arr = arr.OrderByDescending(c => c).ToArray();

            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.Read();
        }

        
    }
}
