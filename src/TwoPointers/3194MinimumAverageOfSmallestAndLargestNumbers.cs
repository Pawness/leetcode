using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.TwoPointers
{
    public class _3194MinimumAverageOfSmallestAndLargestNumbers : RunThisCode
    {
        public double MinimumAverage(int[] nums)
        {
            int start = 0;
            double result = 0;
            int end = nums.Length - 1;
            Array.Sort(nums);
            result = nums[start] + nums[end];
            start++;
            end--;
            while (start < end)
            {
                if (nums[start] + nums[end] < result)
                {
                    result = nums[start] + nums[end];
                }
                start++;
                end--;
            }
            return result / 2;
        }
        public override void RunTheCode()
        {
            MinimumAverage(new int[] { 7, 8, 3, 4, 15, 13, 4, 1 });
        }
    }
}
