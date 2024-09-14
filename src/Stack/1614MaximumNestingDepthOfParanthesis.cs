using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.Stack
{
    public class _1614MaximumNestingDepthOfParanthesis : RunThisCode
    {
        public int MaxDepth(string s)
        {
            int paranthesisCounter = 0, maxDepth = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    paranthesisCounter++;
                    if (maxDepth < paranthesisCounter)
                    {
                        maxDepth = paranthesisCounter;
                    }
                }
                else if (s[i] == ')')
                {
                    paranthesisCounter--;
                }
            }

            return maxDepth;
        
        }
        public override void RunTheCode()
        {
            Console.WriteLine(MaxDepth("()(())((()()))"));
        }
    }
}
