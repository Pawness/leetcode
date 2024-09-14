using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src
{
    internal class _278FirstBadVersion : RunThisCode
    {
        public int FirstBadVersion(int n)
        {
            int start = 1, end = n;
            while (start <= n)
            {

            }
            return -1;
        }

        public override void RunTheCode()
        {
            Console.WriteLine(FirstBadVersion(2));
        }

        private bool IsBadVersion(int v)
        {
            return v == 1 ? true : false;
        }
    }
}
