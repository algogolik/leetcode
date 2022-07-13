namespace LeetCode
{
    public static class RunningSumof1dArray
    {
        /// <summary>
        /// Given an array <c>nums</c>. We define a running sum of an array as <c>runningSum[i] = sum(nums[0]…nums[i])</c>.
        /// </summary>
        /// <param name="nums"> Return the running sum of <c>nums</c>.</param>
        /// <returns></returns>
        public static int[] RunningSum(int[] nums)
        {
            if (nums.Length < 1 || nums.Length > 1000)
                throw new ArgumentException($"1 <= {nums}.length <= 1000");
            /*
             1 <= nums.length <= 1000
             */
            var sum = 0;
            var result = new Queue<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                // Constraints:
                // -10^6 <= nums[i] <= 10^6
                sum += nums[i];
                result.Enqueue(sum);
            }

            return result.ToArray();
        }
    }
}
