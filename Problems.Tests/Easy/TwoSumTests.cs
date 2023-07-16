using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class TwoSumTests
    {
        private static TwoSumSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new TwoSumSolution();
        }

        [DataTestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [DataRow(new int[] { 31, 12, 24 }, 6, new int[] { -1, -1 })]
        public void First_Solution_Tests(int[] nums, int target, int[] expectedResult)
        {
            var actualResult = _solution.TwoSum(nums, target);

            Assert.AreEqual(expectedResult.Length, actualResult.Length);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [DataTestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [DataRow(new int[] { 31, 12, 24 }, 6, new int[] { -1, -1 })]
        public void Second_Solution_Tests(int[] nums, int target, int[] expectedResult)
        {
            var actualResult = _solution.TwoSum2(nums, target);

            Assert.AreEqual(expectedResult.Length, actualResult.Length);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
