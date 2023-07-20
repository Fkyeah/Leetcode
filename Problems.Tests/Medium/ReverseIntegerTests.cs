using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Medium;

namespace Problems.Tests.Medium
{
    [TestClass]
    public class ReverseIntegerTests
    {
        private static ReverseIntegerSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new ReverseIntegerSolution();
        }

        [DataTestMethod]
        [DataRow(1534236469, 0)]
        [DataRow(-123, -321)]
        public void Solution_Tests(int x, int expectedResult)
        {
            var actualResult = _solution.Reverse(x);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
