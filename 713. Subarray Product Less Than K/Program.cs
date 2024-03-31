using System;
using System.Linq;
using System.Collections.Generic;

namespace SubArray
{
    public class Solution
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            int count = 0;
            int elem_count = 2;

            var arr = nums.Split(elem_count);
            
            return count;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] nums = new int[10];
            foreach (int i in nums)
            {
                nums[i] = rand.Next(0, 11);
            }
            Console.WriteLine();
            Solution solution = new Solution();
            Console.WriteLine("Лютое значение: {0}", solution.NumSubarrayProductLessThanK(nums, 100));
        }
    }

}