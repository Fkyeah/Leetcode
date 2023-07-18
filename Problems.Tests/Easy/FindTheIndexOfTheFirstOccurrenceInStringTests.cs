using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class FindTheIndexOfTheFirstOccurrenceInStringTests
    {
        private static FindTheIndexOfTheFirstOccurrenceInStringSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new FindTheIndexOfTheFirstOccurrenceInStringSolution();
        }

        [DataTestMethod]
        [DataRow("sadbutsad", "sad", 0)]
        [DataRow("leetcode", "leeto", -1)]
        public void First_Solution_Tests(string haystack, string needle, int expectedResult)
        {
            var actualResult = _solution.StrStr(haystack, needle);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow("sadbutsad", "sad", 0)]
        [DataRow("leetcode", "leeto", -1)]
        public void Second_Solution_Tests(string haystack, string needle, int expectedResult)
        {
            var actualResult = _solution.StrStr2(haystack, needle);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
