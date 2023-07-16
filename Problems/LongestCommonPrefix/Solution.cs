namespace Problems.LongestCommonPrefix
{
    public class Solution
    {
        public string[] strs = { "flower", "flow", "flight" };
        public string[] strs2 = { "dog", "racecar", "car" };

        /// Runtime - 97ms, Memory - 40.5mb
        public string LongestCommonPrefix(string[] strs)
        {
            string longestPrefix = strs.MinBy(x => x.Length) ?? string.Empty;

            while (longestPrefix.Length > 0)
            {
                if (strs.Count(x => x.StartsWith(longestPrefix)) == strs.Length)
                {
                    return longestPrefix;
                }

                longestPrefix = longestPrefix.Substring(0, longestPrefix.Length - 1);
            }

            return longestPrefix;
        }
    }
}
