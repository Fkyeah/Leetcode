using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class LongestCommonPrefixTests
    {
        [DataTestMethod]
        [DataRow(new string[] { "flower", "flow", "flight" }, "fl")]
        [DataRow(new string[] { "dog", "racecar", "car" }, "")]
        public void SolutionTests(string[] strs, string expectedResult)
        {
            var solution = new LongestCommonPrefixSolution();

            var actualResult = solution.LongestCommonPrefix(strs);

            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
