namespace twopointers
{

    public class CountPairss : RunThisCode
    {
        public void CountPairs(IList<int> nums, int target)
        {
            nums = nums.OrderBy(n => n).ToList();

            int start = 0, count = 0;
            int end = nums.Count() - 1;


            while(start < end)
            {
                if ((nums[start] + nums[end]) < target)
                {
                    count += end - start;
                    start++;
                }
                else
                {
                    end--;
                }
            }
            
            Console.ReadLine();

        }

        public override void RunTheCode()
        {
            CountPairs(new int[] { -6, 2, 5, -2, -7, -1, 3 }, -2);
        }
    }
}