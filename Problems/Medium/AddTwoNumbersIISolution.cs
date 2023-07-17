using Problems.Common;

namespace Problems.Medium
{
    public class AddTwoNumbersIISolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var stackL1 = GetStackFromNode(new Stack<int>(), l1);
            var stackL2 = GetStackFromNode(new Stack<int>(), l2);
            
            var resultStack = stackL1.Count > stackL2.Count
                ? GetResultStack(stackL1, stackL2)
                : GetResultStack(stackL2, stackL1);
            
            return GetResultNode(resultStack);
        }

        private Stack<int> GetResultStack(Stack<int> stackL1, Stack<int> stackL2)
        {
            var reminder = 0;
            int valueL1 = 0;
            int valueL2 = 0;

            var resultStack = new Stack<int>();

            while (stackL1.Count > 0 && stackL1.TryPop(out valueL1))
            {
                var isSuccessL2Pop = stackL2.TryPop(out valueL2);

                var resultValue = isSuccessL2Pop 
                    ? valueL1 + valueL2 + reminder
                    : valueL1 + reminder;

                if (resultValue >= 10)
                {
                    reminder = resultValue / 10;
                    resultStack.Push(resultValue % 10);
                }
                else
                {
                    resultStack.Push(resultValue);
                    reminder = 0;
                }
            }

            if (reminder > 0)
                resultStack.Push(reminder);

            return resultStack;
        }

        private ListNode GetResultNode(Stack<int> resultStack)
        {
            return new ListNode(
                resultStack.Pop(),
                resultStack.Count == 0
                    ? null
                    : GetResultNode(resultStack));
        }

        private Stack<int> GetStackFromNode(Stack<int> stack, ListNode listNode)
        {
            stack.Push(listNode.val);

            if (listNode.next is null)
                return stack;
            else
                return GetStackFromNode(stack, listNode.next);
        }
    }
}
