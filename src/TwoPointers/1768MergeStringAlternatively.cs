using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.src.TwoPointers
{
    public class _1768MergeStringAlternatively : RunThisCode
    {
        public string MergeAlternately(string word1, string word2)
        {
            int i = 0;
            string[] result;

            if (word1.Length > word2.Length)
            {
                int lengthToIterate = word2.Length;
                result = new string[lengthToIterate];
                while(i < lengthToIterate)
                {
                    result[i] = String.Concat(word1[i].ToString() + word2[i].ToString());
                    i++;
                }

                return (String.Join("", result)) + ((word1.Substring(lengthToIterate)));
            }
            else if(word1.Length == word2.Length)
            {
                int lengthToIterate = word2.Length;
                result = new string[lengthToIterate];
                while (i < lengthToIterate)
                {
                    result[i] = String.Concat(word1[i].ToString() + word2[i].ToString());
                    i++;
                }
                return (String.Join("", result));
            }
            else 
            {
                int lengthToIterate = word1.Length;
                result = new string[lengthToIterate];
                while (i < lengthToIterate)
                {
                    result[i] = String.Concat(word1[i].ToString() + word2[i].ToString());
                    i++;
                }
                return (String.Join("", result)) + word2.Substring(lengthToIterate); 
            }
        }

        public override void RunTheCode()
        {
            Console.WriteLine(MergeAlternately("abc" , "pqr"));
        }
    }
}
