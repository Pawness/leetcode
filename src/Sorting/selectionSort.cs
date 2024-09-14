using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.Sorting
{
    public class selectionSort : RunThisCode
    {
        public override void RunTheCode()
        {
            selectionSortExample();
        }

        private void selectionSortExample()
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            //Selection sorting is nothing but selecting the minimum element from the array
            //Placing it in it's place.
            //First min element's place is zero index. Likewise remaining will be followed after.

            //First Step: Selecting the min element

            for(int i = 0; i < arr.Length; i++)
            {
                int start = i + 1;
                int end = arr.Length - 1 , minInx = i;

                //Finding the min element
                while(start < end)
                {
                    if (arr[start] < arr[minInx])
                        minInx = start;

                    if (arr[end] < arr[minInx])
                        minInx = end;

                    start++; end--;
                }

                //swapping the min element 

                int temp = arr[minInx];
                arr[minInx] = arr[i];
                arr[i] = temp;


            }

            Solution.printAnArray(arr);
        }
    }
}
