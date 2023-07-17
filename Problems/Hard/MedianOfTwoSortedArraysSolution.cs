namespace Problems.Hard
{
    public class MedianOfTwoSortedArraysSolution
    {
        /// Runtime - 114ms. Memory - 54.21mb
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var mergedArray = nums1.Concat(nums2).OrderBy(x => x).ToArray();

            if (mergedArray.Length % 2 == 0)
            {
                var n1 = mergedArray[(mergedArray.Length / 2) - 1];
                var n2 = mergedArray[(mergedArray.Length / 2)];

                return (((double)n1 + n2) / 2);
            }
            else
            {
                return mergedArray[mergedArray.Length / 2];
            }
        }
    }
}
