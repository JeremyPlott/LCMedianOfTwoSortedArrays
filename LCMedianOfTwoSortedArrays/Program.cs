using System;
using System.Linq;

namespace LCMedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3, 4 };            

            int[] combined = nums1.Concat(nums2).ToArray();

            Array.Sort(combined);

            Console.WriteLine(FindMedian(combined));

            double FindMedian(int[] arr)
            {
                var arrLength = arr.Length;
                var halfLength = arrLength / 2;

                if (arrLength % 2 != 0)
                {
                    return arr[(arrLength - 1) / 2];
                }

                var oddMedian = (arr[halfLength] + arr[halfLength - 1]) / 2.0;

                return oddMedian;
            }
        }
    }
}
