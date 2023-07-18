namespace Problems.Easy
{
    public class SearchInsertPositionSolution
    {
        public int SearchInsert(int[] nums, int target)
        {
            var index = BinarySearch(nums, target, 0, nums.Length);

            return index;
        }

        private int BinarySearch(int[] nums, int target, int left, int right)
        {
            int mid = left + (right - left) / 2;

            if (left >= right)
            {
                return right;
            }
                
            if (nums[mid] == target)
            {
                return mid;
            }
                
            if (right - left == 1)
            {
                return target > nums[left]
                    ? right
                    : left;
            }

            return nums[mid] > target
                ? BinarySearch(nums, target, left, mid)
                : BinarySearch(nums, target, mid + 1, right);
        }
    }
}
