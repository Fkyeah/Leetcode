namespace Problems
{
    public class TwoSumSolution
    {
        public int[] nums = new int[] { 2, 7, 11, 15 };
        public int[] nums2 = new int[] { 3, 2, 4 };
        public int[] nums3 = new int[] { 3, 3 };
        public int[] nums4 = new int[] { 31, 12, 24 };

        /// O(n^2). Runtime - 216ms, Memory - 44.46mb
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { -1, -1 };
        }

        /// O(n). Runtime - 157ms, Memory - 45.17mb
        public int[] TwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (map.ContainsKey(diff))
                {
                    return new int[] { map[diff], i };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
