using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.Arrays
{
    public class _66PlusOne : RunThisCode
    {
        public int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;

            return newNumber;
        }

        
        public override void RunTheCode()
        {
            PlusOne(new int[]{ 9,9 });
        }
    }
}
