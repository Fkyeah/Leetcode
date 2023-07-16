namespace Problems.Easy
{
    public class RemoveDuplicatesSolution
    {
        /// Runtime - 148ms, Memory - 46.38mb
        public int RemoveDuplicates(int[] nums)
        {
            int i = 1;

            foreach (int number in nums)
            {
                if (nums[i - 1] != number) 
                    nums[i++] = number;
            }

            return i;
        }

        public int RemoveDuplicates2(int[] nums)
        {
            return nums.Distinct().Count();
        }
    }
}
