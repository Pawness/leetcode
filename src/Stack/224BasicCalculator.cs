using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.Stack
{
    public class _224BasicCalculator : RunThisCode
    {
        public int Calulate(string s)
        {
            int currentValue = 0;
            int previousValue = 0;
            int sign = 1;
            Stack<int> st = new Stack<int>();

            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    continue;
                }
                else if (s[i] == '+')
                {
                    previousValue += currentValue * sign;
                    sign = 1;
                }
                else if (s[i] == '-')
                {
                    previousValue += currentValue * sign;
                    sign = -1;
                }
                else if (s[i] == '(')
                {
                    st.Push(previousValue);
                    st.Push(sign);
                    currentValue = 0;
                    previousValue = 0;
                    sign = 1;
                }
                else if (s[i] == ')')
                {
                    previousValue += sign * currentValue;
                    previousValue *= st.Pop();
                    previousValue += st.Pop();
                    currentValue = 0;
                    sign = 1;
                }
                else
                {

                    StringBuilder sb = new StringBuilder();
                    while (i < s.Length && s[i] >= '0' && s[i] <= '9')
                    {
                        sb.Append(s[i]);
                        i++;
                    }

                    Int32.TryParse(sb.ToString(), out currentValue);
                   
                    i--;
                }
            }

            previousValue += currentValue * sign;
            return previousValue;
        }
        
        public override void RunTheCode()
        {
            Console.WriteLine(Calulate("(1+(4+5+2)-3)+(6+8)"));
        }

    }
}
