using Problems.Common;

namespace Problems.Easy
{
    public class MergeTwoSortedListsSolution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var nodeList = GetQueueFromNode(new List<int>(), list1);
            nodeList = GetQueueFromNode(nodeList, list2);


            return GetResultNode(nodeList.OrderBy(x => x).ToList());

        }

        private ListNode GetResultNode(List<int> resultList)
        {
            if (resultList is null || resultList.Count == 0)
                return null;

            var currentValue = resultList[0];
            resultList.RemoveAt(0);

            return new ListNode(
                currentValue,
                resultList.Count == 0
                    ? null
                    : GetResultNode(resultList));
        }

        private List<int> GetQueueFromNode(List<int> list, ListNode listNode)
        {
            if (listNode is null)
                return list;

            list.Add(listNode.val);

            return listNode.next is null
                ? list
                : GetQueueFromNode(list, listNode.next);
        }
    }
}
