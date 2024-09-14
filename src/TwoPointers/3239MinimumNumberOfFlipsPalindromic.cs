using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.TwoPointers
{
    public class _3239MinimumNumberOfFlipsPalindromic : RunThisCode
    {
        public int MinFlips(int[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {

                int start = 0;
                int end = grid[i].Length - 1;

                while (start < end)
                {

                    if (grid[i][start] != grid[i][end])
                    {
                        count++;
                    }

                    start++;
                    end--;
                }
            }
            int count2 = 0;
            for (int i = 0; i < grid[0].Length; i++)
            {
                int start = 0;
                int end = grid.Length - 1;

                while (start < end)
                {
                    if (grid[start][i] != grid[end][i])
                    {
                        count++;
                    }
                    start++;
                    end--;
                }
            }
            return Math.Min(count, count2);
        }

        public override void RunTheCode()
        {
            Console.WriteLine(MinFlips(new int[][]
            {
                [0],[1],[0], [1]
            }));
        }
    }
}
