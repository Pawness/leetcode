using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.TwoPointers
{
    internal class _88MergeSortedArray : RunThisCode
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            if (nums2.Length == 1 && nums1.Length == 1)
            {
                if (nums2[0] == 1)
                {
                    nums1[0] = nums2[0];
                }
            }
            int i = 0;
            while (m < nums1.Length && i < nums2.Length)
            {
                nums1[m] = nums2[i];
                i++;
                m++;
            }
            Sort(nums1);
        }

        private void Sort(int[] nums1)
        {
            int start = 0;
            int last = nums1.Length - 1;

            int pivot = nums1[last];

            //while(start <= last)
            //{
            //    if (nums[start] < )
            //}
        }

        public override void RunTheCode()
        {
            Merge(new int[] { 1, 2, 3, 0, 0, 0 } , 3 , new int[] { 2, 5, 6 } , 3);
        }
    }
}
