using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.Arrays
{
    public class _867TransposeMatrix : RunThisCode
    {
        public override void RunTheCode()
        {
            Transpose(new int[][]
            {
                [1,2,3],
                [4,5,6]
            });
        }

        public int[][] Transpose(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;

            int[][] result = new int[col][];

            for(int i = 0; i < col; i++)
            {
                result[i] = new int[row];
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[j][i] = matrix[i][j];
                }
            }
            return matrix;
        }
    }
}
