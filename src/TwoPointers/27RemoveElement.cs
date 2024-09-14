using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.TwoPointers
{
    public class _27RemoveElement : RunThisCode
    {
        public override void RunTheCode()
        {
            Console.WriteLine(RemoveElement(new int[] { 3, 2, 2, 3 } , 3));
        }

        private int RemoveElement(int[] nums, int val)
        {
            int start = 0;
            int end = nums.Length - 1;
            int count = 0;

            while (start <= end)
            {

                if (nums[start] == val)
                {
                    count++;
                    nums[start] = '_';
                }
                else if (nums[end] == val)
                {
                    count++;
                    nums[end] = '_';
                }

                start++; end--;
            }

            //nums = Sort(nums);

            return nums.Length - 1 - count;
        }

        //public int[] Sort(int[] nums)
        //{
        //    ;
        //}
    }
}
