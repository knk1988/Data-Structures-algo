using System;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Largest Palindrome is:" + LargestPalindrome(n));
            Console.Read();
        }

        public static long LargestPalindrome(int n)
        {
            if (n == 1) return 9;

            long upperBound = GetUpperBound(n);
            long lowerBound = upperBound / 10;
            long maxProduct = upperBound * upperBound;
            bool found = false;
            long palindrome = 0;

            var firstHalf = (maxProduct / (long)Math.Pow(10, n));

            while(!found)
            {
                palindrome = GeneratePalindrome(firstHalf);

                for (long i = upperBound; upperBound > lowerBound; i--)
                {
                    if (palindrome / i > maxProduct || i * i < palindrome)
                    {
                        break;
                    }

                    if (palindrome % i == 0)
                    {
                        found = true;
                        break;
                    }
                }

                firstHalf--;
            }
            return (int)(palindrome % 1337);

        }

        private static long GeneratePalindrome(long number)
        {
            char[] charArray = number.ToString().ToCharArray();
            Array.Reverse(charArray);
            return Convert.ToInt64(number + new string(charArray));
        }
       

        private static long GetUpperBound(int n)
        {
            long min = 1;
            for (int i = n; i > 1; i--)
            {
                min *= 10;
            }
            return (min * 10) - 1;
        }
    }
}
