using Problems.Common;

namespace Problems.Medium
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var queueL1 = GetQueueFromNode(new Queue<int>(), l1);
            var queueL2 = GetQueueFromNode(new Queue<int>(), l2);

            var resultQueue = queueL1.Count > queueL2.Count
                ? GetResultQueue(queueL1, queueL2)
                : GetResultQueue(queueL2, queueL1);

            return GetResultNode(resultQueue);
        }

        private Queue<int> GetResultQueue(Queue<int> queueL1, Queue<int> queueL2)
        {
            var reminder = 0;
            var resultQueue = new Queue<int>();

            while (queueL1.TryDequeue(out var valueL1))
            {
                var isSuccessL2Pop = queueL2.TryDequeue(out var valueL2);

                var resultValue = isSuccessL2Pop
                    ? valueL1 + valueL2 + reminder
                    : valueL1 + reminder;

                if (resultValue >= 10)
                {
                    reminder = resultValue / 10;
                    resultQueue.Enqueue(resultValue % 10);
                }
                else
                {
                    resultQueue.Enqueue(resultValue);
                    reminder = 0;
                }
            }

            if (reminder > 0)
            {
                resultQueue.Enqueue(reminder);
            }


            return resultQueue;
        }

        private ListNode GetResultNode(Queue<int> resultQueue)
        {
            return new ListNode(
                resultQueue.Dequeue(),
                resultQueue.Count == 0
                    ? null
                    : GetResultNode(resultQueue));
        }

        private Queue<int> GetQueueFromNode(Queue<int> queue, ListNode listNode)
        {
            queue.Enqueue(listNode.val);

            return listNode.next is null
                ? queue
                : GetQueueFromNode(queue, listNode.next);

        }
    }
}
