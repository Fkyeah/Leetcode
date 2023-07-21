namespace Problems.Easy
{
    public class LengthOfLastWordSolution
    {
        public int LengthOfLastWord(string s)
        {
            if (s.Length == 0)
                return 0;

            var reverse = s
                .Trim()
                .Reverse();

            var resultLength = 0;
            foreach (var item in reverse)
            {
                if (item == ' ')
                    return resultLength;

                resultLength++;
            }

            return resultLength;
        }

        public int LengthOfLastWord2(string s)
        {
            string[] words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int lengthOfWords = words.Length - 1;

            return words[lengthOfWords].Length;
        }
    }
}
