using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Hard;

namespace Problems.Tests.Hard
{
    [TestClass]
    public class MedianOfTwoSortedArraysTests
    {
        private static MedianOfTwoSortedArraysSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new MedianOfTwoSortedArraysSolution();
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 3 }, new int[] { 2 }, 2.0)]
        [DataRow(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        public void FirstSolution_Tests(int[] nums1, int[] nums2, double expectedResult)
        {
            var actualResult = _solution.FindMedianSortedArrays(nums1, nums2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SecondSolution_Tests()
        {
            Assert.Inconclusive("Необходимо переделать под O(log(n+m))");
        }
    }
}
