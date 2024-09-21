using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.TwoPointers
{
    public class _1544MakeTheStringGreat : RunThisCode
    {
        public string MakeGood(string s)
        {
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (st.Contains(char.ToLower(s[i])) || st.Contains(char.ToUpper(s[i])))
                {
                    if (s[i] - s[i - 1] == 32 || s[i] - s[i - 1] == -32)
                    {
                        st.Pop();
                        s = s.Replace(s.Substring(0, i + 1), string.Join("", st.Reverse()));
                        i = i - 2;
                        continue;
                    }
                }
                st.Push(s[i]);
            }
            //fVETGEeEyYeEegtevFi
            //fVETGEyYeEegtevFi
            //fVETGEeEegtevFi
            //fVETGEegtevFi
            //fVETGgtevFi
            //fVETtevFi
            //fVEevFi
            //fVvFi
            //fFi
            //i

            return string.Join("", st.Reverse());
        }
        public override void RunTheCode()
        {
            Console.WriteLine(MakeGood("fVETGEeEyYeEegtevFi"));
        }
    }
}
