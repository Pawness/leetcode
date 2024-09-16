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
            Console.WriteLine(RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 } , 3));
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
                if (nums[end] == val)
                {
                    count++;
                    nums[end] = '_';
                }

                start++; end--;
            }

            nums = quickSort(nums , 0 , nums.Length - 1);

            return nums.Length - 1 - count;
        }

        private int[] quickSort(int[] nums, int v1, int v2)
        {
            if(v1 < v2)
            {
                int pIndex = partitioning(nums, v1, v2);

                quickSort(nums, v1, pIndex - 1);
                quickSort(nums, pIndex + 1, v2);
            }
            return nums;
        }

        private int partitioning(int[] arr, int v1, int v2)
        {
            int pivot = arr[v2];

            int j = v1 - 1;

            for(int i = v1; i < v2; i++)
            {
                if (arr[i] < pivot)
                {
                    j++;
                    swap(arr, j, i);
                }
            }
            swap(arr, j + 1, v2);
            return j + 1;
        }

        private void swap(int[] arr, int j, int i)
        {
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}
