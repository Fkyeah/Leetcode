using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class RemoveDuplicatesTests
    {
        private static RemoveDuplicatesSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new RemoveDuplicatesSolution();
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
        [DataRow(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4})]
        public void First_Solution_Tests(int[] nums, int[] expectedResult)
        {
            var expectedCount = expectedResult.Length;

            var actualResult = _solution.RemoveDuplicates(nums);

            Assert.AreEqual(expectedCount, actualResult);

            for (int i = 0; i < expectedCount; i++)
            {
                Assert.AreEqual(expectedResult[i], nums[i]);
            }
        }
    }
}
