using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class LengthOfLastWordTests
    {
        private static LengthOfLastWordSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new LengthOfLastWordSolution();
        }

        [DataTestMethod]
        [DataRow("Hello World", 5)]
        [DataRow("   fly me   to   the moon  ", 4)]
        [DataRow("luffy is still joyboy", 6)]
        public void First_Solution_Tests(string s, int expectedResult)
        {
            var actualResult = _solution.LengthOfLastWord(s);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow("Hello World", 5)]
        [DataRow("   fly me   to   the moon  ", 4)]
        [DataRow("luffy is still joyboy", 6)]
        public void Second_Solution_Tests(string s, int expectedResult)
        {
            var actualResult = _solution.LengthOfLastWord2(s);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
