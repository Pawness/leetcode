using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetcode.src.Sorting
{
    public class bubbleSort : RunThisCode
    {
        public void bubbleSortAlgorithm()
        {
//            In Bubble Sort algorithm,

//traverse from left and compare adjacent elements and the higher one is placed at right side. 
//In this way, the largest element is moved to the rightmost end at first.
//This process is then continued to find the second largest and place it and so on until the data is sorted.
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Solution.printAnArray(arr);
        }

        public override void RunTheCode()
        {
            bubbleSortAlgorithm();
        }
    }
}
