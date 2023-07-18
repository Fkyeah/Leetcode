using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class SearchInsertPositionTests
    {
        private static SearchInsertPositionSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new SearchInsertPositionSolution();
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [DataRow(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [DataRow(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [DataRow(new int[] { 1, 3, 5, 6 }, 0, 0)]
        [DataRow(new int[] { 1, 3 }, 4, 2)]
        public void Solution_Tests(int[] nums, int target, int expectedResult)
        {
            var actualResult = _solution.SearchInsert(nums, target);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
