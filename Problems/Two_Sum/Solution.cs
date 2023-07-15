using System.Collections;

namespace Problems.Two_Sum
{
    public class Solution
    {
        public int[] nums = new int[] { 2, 7, 11, 15 };
        public int[] nums2 = new int[] { 3, 2, 4 };
        public int[] nums3 = new int[] { 3, 3 };
        public int[] nums4 = new int[] { 31, 12, 24 };

        /// O(n^2)
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

        //public int[] TwoSum2(int[] nums, int target)
        //{
        //    Dictionary<int, int> table = new();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        var b = target - nums[i];

        //        if (table.ContainsValue(b))
        //        {
        //            var first = Math.Min(i, table.GetValueOrDefault(b));
        //            var second = Math.Max(i, table.GetValueOrDefault(b));

        //            return new int[] { first, second };
        //        }
        //        else
        //        {
        //            table.Add(i.nums[i]);
        //        }
        //    }

        //    return new int[] { -1, -1 };
        //}
    }
}
