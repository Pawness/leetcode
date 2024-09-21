global using System;
global using System.Collections.Generic;
using leetcode.src;
using leetcode.src.Arrays;
using leetcode.src.Sorting;
using leetcode.src.Stack;
using leetcode.src.TwoPointers;
using twopointers;

class Solution
{
    public static void Main(String[] args)
    {
        new Solution().SendTheObject(new _867TransposeMatrix());
    }

    public void SendTheObject(RunThisCode run)
    {
        run.RunTheCode();
    }
    public static void printAnArray<T>(T[] arr)
    {
        foreach(T t in arr)
        {
            Console.WriteLine(t);
        }
    }

}

public abstract class RunThisCode
{
    public abstract void RunTheCode();
}




