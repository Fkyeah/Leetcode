using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Common;
using Problems.Medium;
using System.Collections.Generic;

namespace Problems.Tests.Medium
{
    [TestClass]
    public class AddTwoNumbersIITests
    {
        private static AddTwoNumbersIISolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new AddTwoNumbersIISolution();
        }

        [DataTestMethod]
        [DynamicData(nameof(FirstData), DynamicDataSourceType.Method)]
        [DynamicData(nameof(SecondData), DynamicDataSourceType.Method)]
        public void SolutionTests(ListNode l1, ListNode l2, ListNode expectedResult)
        {
            var actualResult = _solution.AddTwoNumbers(l1, l2);

            Assert.IsTrue(CheckNodes(expectedResult, actualResult));
        }

        private bool CheckNodes(ListNode expectedResult, ListNode actualResult)
        {
            if (expectedResult.next is null && actualResult.next is null)
                return expectedResult.val == actualResult.val;

            return expectedResult.val == actualResult.val && CheckNodes(expectedResult.next, actualResult.next);
        }

        /// <summary>
        /// Input: l1 = [7,2,4,3], l2 = [5,6,4]. Output: [7,8,0,7]
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<ListNode[]> FirstData()
        {
            var l1 = new ListNode(
                7, 
                new ListNode(
                    2, 
                    new ListNode(
                        4, 
                        new ListNode(
                            3, 
                            null)
                        )
                    )
                );

            var l2 = new ListNode(
                5, 
                new ListNode(
                    6, 
                    new ListNode(
                        4, 
                        null)
                    )
                );

            var expectedResult = new ListNode(
                7, 
                new ListNode(
                    8, 
                    new ListNode(
                        0, 
                        new ListNode(
                            7, 
                            null)
                        )
                    )
                );

            return new[]
            {
               new[] { l1, l2, expectedResult }
            };
        }

        /// <summary>
        /// Input: l1 = [1], l2 = [9,9]. Output: [1,0,0]
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<ListNode[]> SecondData()
        {
            var l1 = new ListNode(
                1,
                null
                );

            var l2 = new ListNode(
                9,
                new ListNode(
                    9,
                    null
                    )
                );

            var expectedResult = new ListNode(
                1,
                new ListNode(
                    0,
                    new ListNode(
                        0,
                        null
                        )
                    )
                );

            return new[]
            {
               new[] { l1, l2, expectedResult }
            };
        }
    }
}
