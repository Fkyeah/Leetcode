namespace Problems.PalindromeNumber
{
    public class Solution
    {
        public int x = 121;
        public int x2 = -121;
        public int x3 = 10;

        /// Runtime 73ms, Memory - 32.74mb
        public bool IsPalindrome(int x)
        {
            var digitsArray = x.ToString().ToCharArray();

            return digitsArray[0] == digitsArray[digitsArray.Length - 1]
                && IsEqualArrays(digitsArray, digitsArray.Reverse());
        }

        private bool IsEqualArrays(IEnumerable<char> array1, IEnumerable<char> array2)
        {
            if (array1.Count() != array2.Count())
                return false;

            var firstEnumerator = array1.GetEnumerator();
            var secondEnumerator = array2.GetEnumerator();

            for (int i = 0; i < array1.Count(); i++)
            {
                firstEnumerator.MoveNext();
                secondEnumerator.MoveNext();

                var first = firstEnumerator.Current;
                var second = secondEnumerator.Current;

                if (!first.Equals(second))
                    return false;
            }

            return true;
        }
    }
}
