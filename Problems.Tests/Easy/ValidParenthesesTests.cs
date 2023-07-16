using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class ValidParenthesesTests
    {
        private static ValidParenthesesSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new ValidParenthesesSolution();
        }

        [DataTestMethod]
        [DataRow("()", true)]
        [DataRow("()[]{}", true)]
        [DataRow("(]", false)]
        [DataRow("{[]}", true)]
        public void Solution_Tests(string parentheses, bool expectedResult)
        {
            var actualResult = _solution.IsValid(parentheses);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
