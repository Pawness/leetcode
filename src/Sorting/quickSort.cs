using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.Sorting
{
    public class quickSort : RunThisCode
    {
        // have to do again
        public int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex - 1;

            int pivot = array[leftIndex];

            while(i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if(i <= j)
                {

                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);
            if (i < rightIndex)
                SortArray(array, i, rightIndex);

            Solution.printAnArray(array);
            return array;
        }
        public override void RunTheCode()
        {
            SortArray(new int[] { 52, 96, 67, 71, 42, 38, 39, 40, 14 } , 0 , new int[] { 52, 96, 67, 71, 42, 38, 39, 40, 14 }.Length);
        }
    }
}
