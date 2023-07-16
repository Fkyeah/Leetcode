using System.Text;

namespace Problems.Easy
{
    public class PalindromeNumberSolution
    {
        public int x = 121;
        public int x2 = -121;
        public int x3 = 10;

        /// Runtime 73ms, Memory - 32.74mb
        public bool IsPalindrome(int x)
        {
            var digitsArray = x.ToString().ToCharArray();

            return IsEqualArrays(digitsArray, digitsArray.Reverse());
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

        /// Runtime 65ms, Memory - 29.48mb
        public bool IsPalindrome2(int x)
        {
            int reverse = 0;
            int current = x;

            while (current > 0)
            {
                reverse = reverse * 10 + current % 10;
                current /= 10;
            }

            return reverse == x;
        }

        /// Runtime 40ms, Memory - 34.98mb
        public bool IsPalindrome3(int x)
        {
            var currentHash = Encoding.ASCII.GetBytes(x.ToString());
            var reverseHash = Encoding.ASCII.GetBytes(x.ToString().Reverse().ToArray());
            if (currentHash.Length == reverseHash.Length)
            {
                int i = 0;
                while (i < currentHash.Length && currentHash[i] == reverseHash[i])
                {
                    i += 1;
                }

                if (i == reverseHash.Length)
                {
                    return true;
                }
            }

            return false;
        }

        /// Runtime 45ms, Memory - 29.60mb
        public bool IsPalindrome4(int x)
        {
            var current = x.ToString();
            return IsPalin(current, 0, current.Length - 1);

            bool IsPalin(string x, int start, int end)
            {
                if (start >= end)
                {
                    return true;
                }
                if (x[start] != x[end])
                {
                    return false;
                }
                return IsPalin(x, start + 1, end - 1);
            }
        }
    }
}
