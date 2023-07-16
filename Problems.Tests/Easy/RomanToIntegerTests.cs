using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class RomanToIntegerTests
    {
        private static RomanToIntegerSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new RomanToIntegerSolution();
        }

        [DataTestMethod]
        [DataRow("III", 3)]
        [DataRow("LVIII", 58)]
        [DataRow("MCMXCIV", 1994)]
        [DataRow("MMCMXCIV", 2994)]
        [DataRow("IV", 4)]
        public void Solution_Tests(string romanNumber, int expectedResult)
        {
            var actualResult = _solution.RomanToInt(romanNumber);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
