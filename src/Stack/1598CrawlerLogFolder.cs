using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.Stack
{
    public class _1598CrawlerLogFolder : RunThisCode
    {
        public int MinOperations(string[] logs)
        {
            Stack<string> output = new Stack<string>();
            string currentFolder = "./", back = "../";

            for (int i = 0; i < logs.Length; i++)
            {
                if (logs[i] != currentFolder && logs[i] != back)
                {
                    output.Push(logs[i]);
                }
                else if (logs[i] == back)
                {
                    if(output.Count() > 0)
                        output.Pop();
                }
            }

            return output.Count();
        }
        public override void RunTheCode()
        {
            Console.WriteLine(MinOperations(new string[] {"d1/","d2/","../","d21/","./"}));
        }
    }
}
