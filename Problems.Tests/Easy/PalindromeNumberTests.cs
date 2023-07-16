using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class PalindromeNumberTests
    {
        private static PalindromeNumberSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new PalindromeNumberSolution();
        }

        [DataTestMethod]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(123321, true)]
        [DataRow(10000201, false)]
        [DataRow(10, false)]
        public void First_Solution_Test(int number, bool expectedResult)
        {
            var actualResult = _solution.IsPalindrome(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(123321, true)]
        [DataRow(10000201, false)]
        [DataRow(10, false)]
        public void Second_Solution_Test(int number, bool expectedResult)
        {
            var actualResult = _solution.IsPalindrome2(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(123321, true)]
        [DataRow(10000201, false)]
        [DataRow(10, false)]
        public void Third_Solution_Test(int number, bool expectedResult)
        {
            var actualResult = _solution.IsPalindrome3(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(123321, true)]
        [DataRow(10000201, false)]
        [DataRow(10, false)]
        public void Fourth_Solution_Test(int number, bool expectedResult)
        {
            var actualResult = _solution.IsPalindrome4(number);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
