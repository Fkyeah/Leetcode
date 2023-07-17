using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Common;
using Problems.Easy;
using System.Collections.Generic;

namespace Problems.Tests.Easy
{
    [TestClass]
    public class MergeTwoSortedListsTests
    {
        private static MergeTwoSortedListsSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new MergeTwoSortedListsSolution();
        }

        [DataTestMethod]
        [DynamicData(nameof(FirstData), DynamicDataSourceType.Method)] 
        [DynamicData(nameof(SecondData), DynamicDataSourceType.Method)] 
        [DynamicData(nameof(ThirdData), DynamicDataSourceType.Method)] 
        public void Solution_Tests(ListNode list1, ListNode list2, ListNode expectedResult)
        {
            var actualResult = _solution.MergeTwoLists(list1, list2);

            Assert.IsTrue(CheckNodes(expectedResult, actualResult));
        }

        private bool CheckNodes(ListNode expectedResult, ListNode actualResult)
        {
            if (expectedResult is null && expectedResult is null)
                return true;

            if (expectedResult.next is null && actualResult.next is null)
                return expectedResult.val == actualResult.val;

            return expectedResult.val == actualResult.val && CheckNodes(expectedResult.next, actualResult.next);
        }

        /// <summary>
        /// Input: l1 = [1,2,4], l2 = [1,3,4]. Output: [1,1,2,3,4,4]
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<ListNode[]> FirstData()
        {
            var l1 = new ListNode(
                1,
                new ListNode(
                    2,
                    new ListNode(
                        4,
                        null)
                    )
                );

            var l2 = new ListNode(
                1,
                new ListNode(
                    3,
                    new ListNode(
                        4,
                        null)
                    )
                );

            var expectedResult = new ListNode(
                1,
                new ListNode(
                    1,
                    new ListNode(
                        2,
                        new ListNode(
                            3,
                            new ListNode(
                                4,
                                new ListNode(
                                    4,
                                    null
                                    )
                                )
                            )
                        )
                    )
                );

            return new[]
            {
               new[] { l1, l2, expectedResult }
            };
        }

        /// <summary>
        /// Input: l1 = [], l2 = []. Output: []
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<ListNode[]> SecondData()
        {
            ListNode l1 = null;

            ListNode l2 = null;

            ListNode expectedResult = null;

            return new[]
            {
               new[] { l1, l2, expectedResult }
            };
        }

        /// <summary>
        /// Input: l1 = [], l2 = [0]. Output: [0]
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<ListNode[]> ThirdData()
        {
            ListNode l1 = null;

            var l2 = new ListNode(
                0,
                null
                );

            var expectedResult = new ListNode(
                0,
                null
                );

            return new[]
            {
               new[] { l1, l2, expectedResult }
            };
        }
    }
}
