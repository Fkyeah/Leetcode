using System.Text.RegularExpressions;

namespace Problems.Easy
{
    public class FindTheIndexOfTheFirstOccurrenceInStringSolution
    {
        public int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }

        public int StrStr2(string haystack, string needle)
        {
            var match = Regex.Match(haystack, needle);

            return !match.Success
                ? -1
                : match.Index;
        }
    }
}
