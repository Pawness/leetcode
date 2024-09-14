using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.TwoPointers
{
    internal class _3240MinimumNumberofFlipstoMakeBinaryGridPalindromicII : RunThisCode
    {
        public int MinFlips(int[][] grid)
        {
            int m = grid.Length, halfM = m / 2, n = grid[0].Length, halfN = n / 2;
            int ans = 0;
            int j = 0;

            //For checking all the possible squares
            for (int i = 0; i < halfM; i++)
            {
                j = 0;
                while (j < halfN)
                {
                    int rectOnes = grid[i][j] + grid[m - 1 - i][j] + grid[i][n - 1 - j] + grid[m - 1 - i][n - 1 - j];
                    if (rectOnes > 2)
                        ans += 4 - rectOnes;
                    else
                        ans += rectOnes;
                    j++;
                }
            }

            int numOfOnes = 0, count = 0;
            if (m % 2 == 1)
            {
                for (int i = 0; i < halfN; i++)
                {
                    if (grid[halfM][i] != grid[halfM][n - 1 - i])
                    {
                        ans++;
                        count++;
                        continue;
                    }
                    numOfOnes += grid[halfM][i];
                }
            }

            if (n % 2 == 1)
            {
                for (int i = 0; i < halfM; i++)
                {
                    if (grid[i][halfN] != grid[m - 1 - i][halfN])
                    {
                        ans++;
                        count++;
                        continue;
                    }
                    numOfOnes += grid[i][halfN];
                }
            }

            if (numOfOnes % 2 != 0 && count == 0)
                ans += 2;

            if (m % 2 == 1 && n % 2 == 1)
                if (grid[halfM][halfN] != 0)
                    ans++;

            return ans;
        }

        public override void RunTheCode()
        {
            Console.WriteLine(MinFlips(new int[][]
            {
                [0,1],
                [0,1],
                [0,0]
            }));
        }
    }
}
