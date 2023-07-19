using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class PascalTriangleIITests
    {
        private static PascalTriangleIISolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new PascalTriangleIISolution();
        }

        [DataTestMethod]
        [DataRow(3, new int[] { 1, 3, 3, 1 })]
        [DataRow(0, new int[] { 1 })]
        [DataRow(1, new int[] { 1, 1 })]
        [DataRow(4, new int[] { 1, 4, 6, 4, 1 })]
        public void Solution_Tests(int rowIndex, int[] expectedResult)
        {
            var actualResult = _solution.GetRow(rowIndex);

            for (int j = 0; j < expectedResult.Length; j++)
            {
                Assert.AreEqual(expectedResult[j], actualResult[j]);
            }
        }
    }
}
