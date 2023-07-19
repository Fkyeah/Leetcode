using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class PascalTriangleTests
    {
        private static PascalTriangleSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new PascalTriangleSolution();
        }

        [DataTestMethod]
        [DataRow(5)]
        public void Solution_Tests(int numRows)
        {
            var expectedResult = new int[][] { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 2, 1 }, new int[] { 1, 3, 3, 1 }, new int[] { 1, 4, 6, 4, 1 } };

            var actualResult = _solution.Generate(numRows);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                for (int j = 0; j < expectedResult[i].Length; j++)
                {
                    Assert.AreEqual(expectedResult[i][j], actualResult[i][j]);
                }
            }
        }
    }
}
