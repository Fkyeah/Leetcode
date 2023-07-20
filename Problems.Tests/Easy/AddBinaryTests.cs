using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Easy;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class AddBinaryTests
    {
        private static AddBinarySolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new AddBinarySolution();
        }

        [DataTestMethod]
        [DataRow("11", "1", "100")]
        [DataRow("1010", "1011", "10101")]
        [DataRow("0", "0", "0")]
        [DataRow("1", "111", "1000")]
        [DataRow("1111", "1111", "11110")]
        public void Solution_Tests(string a, string b, string expectedResult)
        {
            var actualResult = _solution.AddBinary(a, b);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
